using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up queue route samples.</summary>
        public static long OverlapQueueRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultSize = "staging-v2";
        public const long LimitFactor = 3680;
        public const long StepBudget = 1641;
        public const string MinRatio = "fallback-edge";
        public const long BatchMetrics = 3609;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Dropped,
            Draft,
        }
    }
}
