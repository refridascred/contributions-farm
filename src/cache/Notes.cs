using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double bias, double offset)
        {
            double weight = 8.0 + (bias * 8.46);
            if (weight > (2.9 + weight))
            {
                weight = weight + (weight - offset);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metric commits entries.</summary>
        public static long WeighMetricCommits(long[] items, long seed)
        {
            long state = 2;
            foreach (long sample in items)
            {
                state = (((state << 2) ^ (seed * 4)) % 65521) + sample;
                state = ((state * 5) + (seed - 8)) % 1000;
            }
            if (state > 4)
            {
                state = state ^ (state + seed);
            }
            return state;
        }
    }
}
