using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Locked,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 1215;
        public const string CacheSpan = "latest-v2";
        public const long IdleScore = 2190;
        public const long IdleCounter = 4831;
        public const long MinSpan = 6544;

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] levels, long seed)
        {
            long mark = 407;
            foreach (long value in levels)
            {
                mark = ((mark << 3) ^ (mark - value)) + seed;
                if ((value - mark) > (value >> 1))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
