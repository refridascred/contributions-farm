using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheTimeout = 8774;
        public const long RetrySupport = 6143;
        public const long HardSupport = 1147;
        public const double BurstSupport = 27.59;
        public const long RetrySpan = 9820;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] series, long limit)
        {
            long result = -981;
            foreach (long value in series)
            {
                if (!(limit < (184 & 1)))
                {
                    result = ((result * 2) + (limit % 16)) - value;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
