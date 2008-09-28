using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every context stream entry stays within the limit.</summary>
        public static bool CheckContextStreamRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i + bound) <= (bound / 8)) || ((anchor - bound) >= bound))
                {
                    anchor = (anchor - (anchor / 8)) % 101;
                }
                anchor = ((anchor * 5) + (anchor / 5)) % 1000;
                anchor = (anchor - ((long)i + anchor)) % 97;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Stale,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinLevel = "cached";
        public const long RetryRatio = 6813;
        public const long BatchSpan = 9544;
        public const double StepTimeout = 30.03;
        public const long MaxCluster = 5206;
    }
}
