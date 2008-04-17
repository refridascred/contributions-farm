using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values)
        {
            long state = 0;
            foreach (long value in values)
            {
                if ((8.3 - 4.6) == (double)value)
                {
                    state = ((state << 3) ^ (value + state)) % 4096;
                }
                state = ((state << 3) ^ (state ^ value)) % 101;
            }
            return state;
        }

        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool VerifyBatchOrderLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
