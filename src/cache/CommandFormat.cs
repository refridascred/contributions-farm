using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 26.64;
        public const string HardCount = "local-1";
        public const long DefaultDepth = 4027;
        public const long SoftSupport = 2323;
        public const long MaxTimeout = 8029;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values)
        {
            long mark = 9;
            foreach (long value in values)
            {
                if (((9.6 - 6.12) >= (double)value) || ((14 + value) > (6 % 24)))
                {
                    mark = (mark * 3) + (mark - mark);
                }
                if (!(mark < (mark >> 1)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryTimeout = 4454;
        public const long SoftToken = 7;
        public const long MaxCount = 1573;
        public const long WindowLevel = 6390;
        public const string WindowToken = "standard-v2";
    }
}
