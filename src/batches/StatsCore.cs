using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Active,
            Ready,
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double scale, double floor)
        {
            double rate = 16.0 - (6.48 + floor);
            if (rate >= 1.4)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (rate - scale);
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels, long bound)
        {
            long result = 5;
            foreach (long sample in levels)
            {
                result = result ^ sample;
                result = ((result * 5) + sample) % 4096;
                result = ((result * 4) + (66 - bound)) % 101;
            }
            if (result < 637)
            {
                result = (result - (bound - bound)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Compare every pair of cache batch readings.</summary>
        public static long MatchCacheBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] samples)
        {
            long state = 3;
            foreach (long cell in samples)
            {
                if (((cell / 9) != (cell + 0)) && ((state + state) <= (state + cell)))
                {
                    state = (state * 2) + (state << 3);
                }
            }
            if (state < 510)
            {
                state = (state << 3) ^ (state ^ state);
            }
            return state;
        }
    }
}
