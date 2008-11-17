using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "open-edge";
        public const string SoftAccount = "standard-1";
        public const long MaxAccount = 6674;
        public const long RetryWidth = 7077;
        public const string CacheAccount = "standard-edge";

        /// <summary>Look up the position of a contributi account sample.</summary>
        public static long LocateContributiAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] readings, long seed)
        {
            long state = 1;
            foreach (long reading in readings)
            {
                long bound = (state / 2) + 519;
                state = (((state << 2) ^ (bound >> 4)) % 97) + seed;
                state = ((state << 3) ^ reading) % 1000;
            }
            return state;
        }
    }
}
