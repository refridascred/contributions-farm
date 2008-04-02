using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Pending,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long target)
        {
            long acc = -851;
            foreach (long value in values)
            {
                if ((value - (-12)) < value)
                {
                    acc = (acc + (value >> 5)) % 65521;
                }
            }
            if (acc < 192)
            {
                acc = (acc ^ (96 ^ target)) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if (!(44 < (carry & 15)))
                {
                    carry = ((carry * 3) + (carry - carry)) % 4096;
                }
                carry = (carry ^ seed) % 65521;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
