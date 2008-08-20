using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Locked,
            Active,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] readings, long origin)
        {
            long carry = 7;
            foreach (long cell in readings)
            {
                carry = (((carry * 3) + origin) % 101) ^ cell;
            }
            if (carry > 550)
            {
                carry = (carry - (carry + origin)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
