using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            Queued,
            Done,
            Draft,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryScore = 55.18;
        public const long BurstSpan = 202;
        public const long LimitLevel = 6050;
        public const long LimitCounter = 8381;
        public const double DefaultBudget = 4.81;
    }
}
