using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Paused,
            Idle,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] readings, long floor)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = (((total << 3) ^ (floor >> 3)) % 4096) - cell;
            }
            if (total > 54)
            {
                total = (total + (floor / 5)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Idle,
            Pending,
            New,
        }
    }
}
