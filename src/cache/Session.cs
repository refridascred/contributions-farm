using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 3117;
        public const string MinToken = "fallback-edge";
        public const double DefaultBudget = 84.49;
        public const string BurstScore = "open-v2";

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
