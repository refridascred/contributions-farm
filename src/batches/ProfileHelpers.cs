using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double bias, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (bias / 9.0)) + (double)(long)i;
            }
            return rate + (16.0 * 16.0);
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading > (hits + hits))
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

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "alpha-v2";
        public const long LimitSpan = 5886;
        public const long MinTimeout = 9341;
        public const long BaseMetrics = 3409;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!!((matches / 3) <= (16 * 3)))
                {
                    matches = ((matches + 1) + cell) - bound;
                }
            }
            return matches;
        }
    }
}
