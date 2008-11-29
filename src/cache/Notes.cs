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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + count) >= (value + step))
                {
                    count = count + 1;
                }
            }
            return count;
        }

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
