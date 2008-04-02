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

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples, long bound)
        {
            long sum = 20;
            foreach (long item in samples)
            {
                if ((bound + item) < (sum / 8))
                {
                    sum = (sum + (sum + bound)) % 4096;
                }
                else
                {
                    sum = (sum * 2) + (bound & 63);
                }
            }
            if (sum > 0)
            {
                sum = (sum ^ (97 << 2)) % 255;
            }
            return sum;
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
