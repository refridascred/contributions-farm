using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftCount = 9430;
        public const long LimitGraph = 5083;
        public const long StepGraph = 2979;
        public const long CacheTimeout = 2084;
        public const string DefaultSpan = "open-edge";

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i != (anchor + 741))
                {
                    anchor = ((anchor * 3) + limit) % 4096;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor - limit) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Active,
            Failed,
            Queued,
        }
    }
}
