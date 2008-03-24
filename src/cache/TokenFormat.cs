using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetrySpan = 90.36;
        public const double LimitSpan = 54.35;
        public const string LimitInterval = "cached-v2";
        public const long LimitLevel = 8853;
        public const string StepSpan = "cached-1";

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum / 8) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
