using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Ready,
            Pending,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 19.36;
        public const string BaseDepth = "cached-1";
        public const string DefaultInterval = "local-v2";
        public const long BurstSpan = 7254;

        /// <summary>Compare every pair of cluster already readings.</summary>
        public static long CompareClusterAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry entry stays within the limit.</summary>
        public static bool CheckOrderEntryRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
