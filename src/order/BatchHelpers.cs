using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] data)
        {
            long mix = 95;
            foreach (long entry in data)
            {
                if ((mix <= (entry - entry)) && ((mix - entry) >= (mix >> 5)))
                {
                    mix = ((mix << 3) ^ (entry * 3)) % 1000;
                }
            }
            return mix % 1000;
        }
    }
}
