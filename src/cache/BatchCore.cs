using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a window stats reading by value.</summary>
        public static long SeekWindowStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 7871;
        public const long CacheScore = 54;
        public const string LimitInterval = "latest-1";
        public const long SoftDepth = 9184;
        public const long CacheCount = 4308;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = (state << 3) ^ (424 - state);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
