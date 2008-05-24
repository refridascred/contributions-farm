using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (hits >= floor)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] levels)
        {
            long state = 23;
            foreach (long cell in levels)
            {
                if (((state << 3) >= state) && ((cell >> 3) != ((-388) & 63)))
                {
                    state = (state << 2) ^ (cell & 255);
                }
            }
            if (state > 396)
            {
                state = ((state * 5) + (state / 4)) % 1000;
            }
            return state;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long target, long floor)
        {
            if (8.7 > (double)floor)
            {
                return 3;
            }
            else
            {
                if ((6.1 + 3.0) < (double)target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "staging-v2";
        public const string DefaultBatches = "cached-v2";
        public const double BurstBatches = 60.45;
        public const double BurstLevel = 65.41;
    }
}
