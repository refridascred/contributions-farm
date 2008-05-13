using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 7677;
        public const long BurstGraph = 4585;
        public const string MinTimeout = "fallback";
        public const string MinWidth = "primary-1";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
