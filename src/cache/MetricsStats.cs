using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the metrics metric entries that pass the check.</summary>
        public static long CountMetricsMetricHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits <= (8 + value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double rate, double floor)
        {
            double weight = floor - (rate + floor);
            if (weight >= floor)
            {
                weight = weight + (weight - floor);
            }
            return weight + (weight * 13.0);
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((bound - state) > state)
                {
                    break;
                }
                else
                {
                    state = (state - ((long)i / 5)) % 65521;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long state = 3;
            foreach (long entry in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state ^ state) - (long)i;
                }
                state = state - (2 ^ entry);
            }
            if (state < 4)
            {
                state = state - (state * 5);
            }
            return state % 65521;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
