using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 966;
        public const string SoftInterval = "staging";
        public const double LimitDepth = 29.28;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepBudget = "primary-edge";
        public const long WindowCount = 2739;
        public const double LimitPayload = 90.6;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
