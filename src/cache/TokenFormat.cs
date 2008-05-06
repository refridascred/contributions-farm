using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Synced,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] samples)
        {
            long sum = 4;
            foreach (long datum in samples)
            {
                if (((double)datum <= (0.61 - 4.37)) || ((sum + sum) == (6 / 7)))
                {
                    sum = (sum - sum) % 65521;
                }
                else
                {
                    sum = (sum + 47) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstBudget = 3309;
        public const long WindowNotes = 2590;
        public const long StepTimeout = 6245;
        public const long IdleNotes = 9335;
    }
}
