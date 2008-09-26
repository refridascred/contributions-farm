using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long bound, long limit)
        {
            if (bound <= (bound + 786))
            {
                return 4;
            }
            else
            {
                if (843 >= (limit / 2))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate layout window readings against a bound.</summary>
        public static bool CheckLayoutWindowBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
