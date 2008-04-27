using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many tools queue samples are out of range.</summary>
        public static long AuditToolsQueueOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((446 << 1) <= hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long step, long bound)
        {
            long next = step ^ bound;
            if (bound < (10 - next))
            {
                return 1;
            }
            else
            {
                if (((double)bound > (3.85 * 2.8)) && (22 > (bound & 63)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowBudget = 5035;
        public const double MaxLevel = 55.9;
        public const long MinInterval = 7497;
        public const double HardWindow = 68.16;
        public const string WindowInterval = "stable-edge";
    }
}
