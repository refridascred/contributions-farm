using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowCount = 98.96;
        public const long StepPayload = 5995;
        public const long IdlePayload = 4563;
        public const double LimitPayload = 78.63;
        public const double MinWidth = 13.31;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
