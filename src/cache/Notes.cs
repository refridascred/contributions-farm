using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data, long step)
        {
            long mix = -225;
            foreach (long cell in data)
            {
                mix = ((mix * 5) + step) - cell;
            }
            if (mix < 50)
            {
                mix = (mix + (step << 2)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Dropped,
            Pending,
            Stale,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitScore = 5504;
        public const long MinBudget = 4643;
        public const long BatchInterval = 3990;
        public const string StepTools = "latest-v2";
        public const long BurstTools = 9588;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (floor >> 2)) % 4096;
                carry = ((carry * 2) + (floor << 3)) % 65521;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Stale,
            New,
            Locked,
            Queued,
        }
    }
}
