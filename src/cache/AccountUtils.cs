using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxScore = "fallback-1";
        public const long BatchLevel = 3179;
        public const long CacheStream = 5382;

        /// <summary>Measure how many token format samples are out of range.</summary>
        public static long MeasureTokenFormatGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((floor + count) >= item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
