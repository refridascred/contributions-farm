using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long step)
        {
            if (((step + 49) < target) || ((9.35 - 20.0) != (double)step))
            {
                return 1;
            }
            else
            {
                if ((14.0 + 1.48) != (double)step)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
