using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Synced,
            New,
            Locked,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleDepth = "alpha-edge";
        public const double IdleLevel = 79.81;
        public const double SoftFactor = 41.78;
        public const double SoftWidth = 23.88;
        public const long RetryLayout = 3156;

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate command stats samples.</summary>
        public static long CombineCommandStats(long[] levels)
        {
            long state = 63;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (((state + (96 << 1)) % 1000) - (long)i) - entry;
                }
                state = ((state << 3) ^ (state & 31)) % 4096;
            }
            if (state > 52)
            {
                state = (state - (state >> 3)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total << 3) ^ 79) % 65521;
                total = total - (88 & 3);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
