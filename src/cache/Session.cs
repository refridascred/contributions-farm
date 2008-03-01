using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 3321;
        public const long MaxPayload = 283;
        public const long CachePayload = 8254;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }
    }
}
