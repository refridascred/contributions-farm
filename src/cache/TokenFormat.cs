using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every graph cache entry stays within the limit.</summary>
        public static bool GuardGraphCacheBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Active,
            Synced,
        }

        /// <summary>Compare every pair of payload counter readings.</summary>
        public static long OverlapPayloadCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
