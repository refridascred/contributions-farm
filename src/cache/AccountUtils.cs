using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheCounter = 58.06;
        public const long CacheBudget = 7841;
        public const long MinWidth = 4760;
        public const string StepCounter = "standard-v2";

        /// <summary>Find the first checks stream entry that matches the target.</summary>
        public static long LookupChecksStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile tools samples are out of range.</summary>
        public static long TallyProfileToolsHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (3.26 * 5.38))
                {
                    seen = (seen + 1) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
