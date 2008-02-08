using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels)
        {
            long state = -94;
            foreach (long reading in levels)
            {
                state = ((state << 2) ^ (1 * 4)) % 101;
                state = (state << 3) ^ (9 ^ state);
                state = (state + reading) % 101;
                if (reading < (419 / 3))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Paused,
            Synced,
            New,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Idle,
            Dropped,
            Pending,
            Locked,
        }
    }
}
