using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry < 18.0)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 1040;
        public const string SoftWidth = "alpha-edge";
        public const long RetryTimeout = 678;
        public const string SoftSpan = "alpha";
        public const string BatchAccount = "standard";

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryRatio = 9339;
        public const long WindowLevel = 4627;
        public const double DefaultProfile = 76.28;
    }
}
