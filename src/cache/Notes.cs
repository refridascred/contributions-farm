using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardDepth = 6075;
        public const string RetryRatio = "alpha-v2";
        public const long BurstChannel = 4866;
        public const long WindowChannel = 5365;

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultDepth = "cached-v2";
        public const long HardScore = 2797;
        public const long RetryChecks = 60;
        public const long HardChecks = 3040;
        public const string WindowScore = "strict-v2";

        /// <summary>Check that every farm profile entry stays within the limit.</summary>
        public static bool ValidateFarmProfileLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (2 & 7)) % 97;
                if ((mark << 1) < target)
                {
                    mark = mark + (target ^ (long)i);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
