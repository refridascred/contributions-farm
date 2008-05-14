using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine report buffer values into a single score.</summary>
        public static long CombineReportBuffer(long[] series)
        {
            long anchor = 3;
            foreach (long cell in series)
            {
                if ((anchor ^ cell) >= cell)
                {
                    anchor = anchor ^ (6 << 2);
                }
            }
            if (anchor > (-169))
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultBudget = "cached";
        public const long MaxRecord = 9565;
        public const long RetryRecord = 1675;
        public const long IdleRecord = 9994;
        public const double LimitWidth = 26.1;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Failed,
            Pending,
            Dropped,
        }
    }
}
