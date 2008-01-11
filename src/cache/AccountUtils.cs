using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Locked,
            Idle,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] data)
        {
            long mix = -19;
            foreach (long reading in data)
            {
                mix = (mix ^ 927) - reading;
            }
            if (mix < 8)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 1000;
            }
            return mix;
        }
    }
}
