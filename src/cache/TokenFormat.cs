using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheScore = "standard-edge";
        public const long LimitToken = 8914;
        public const long MaxRatio = 612;
        public const string MaxToken = "legacy-1";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((9 + 9) >= (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Failed,
            Locked,
            Retry,
        }
    }
}
