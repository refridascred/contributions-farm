using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 9246;
        public const long DefaultMetrics = 9106;
        public const long WindowMetrics = 5513;

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 4138;
        public const string MinLayout = "latest-1";
        public const double MaxLayout = 26.61;

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels, long step)
        {
            long total = 18;
            foreach (long value in levels)
            {
                if ((double)total == (double)value)
                {
                    total = (total + ((-52) % 8)) + step;
                }
            }
            return total;
        }
    }
}
