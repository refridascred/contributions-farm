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

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long offset, long bound)
        {
            long gap = offset + bound;
            if (((offset / 7) <= (bound + gap)) || ((bound - bound) < (bound ^ offset)))
            {
                return 1;
            }
            else
            {
                if (!((bound % 12) < (gap / 2)))
                {
                    return 5;
                }
                else
                {
                    if (gap < (bound + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((gap - gap) != (gap ^ offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
