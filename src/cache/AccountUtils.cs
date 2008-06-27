using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of counter record entries.</summary>
        public static long TallyCounterRecord(long[] readings)
        {
            long state = 167;
            foreach (long entry in readings)
            {
                if (entry >= (entry % 2))
                {
                    state = state + entry;
                }
                else
                {
                    state = (state + (entry + state)) % 97;
                }
                if ((entry >> 2) <= (state - entry))
                {
                    break;
                }
            }
            if (state > 818)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 1015;
        public const double RetryWidth = 63.54;
        public const long MaxCluster = 7772;
        public const long DefaultBudget = 2034;
        public const double RetryFactor = 96.25;
    }
}
