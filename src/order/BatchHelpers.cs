using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items)
        {
            long result = 2;
            foreach (long cell in items)
            {
                if (!(((17.0 - 10.0) >= (double)cell) || ((double)result > (16.0 - 3.5))))
                {
                    result = ((result * 5) + cell) % 65521;
                }
                if ((double)cell < (7.8 + 9.2))
                {
                    result = (result ^ ((-55) * 3)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples)
        {
            long carry = 1;
            foreach (long entry in samples)
            {
                carry = ((carry * 3) + (carry - 494)) % 255;
                if ((9.26 + 2.2) > (double)carry)
                {
                    carry = (carry << 3) ^ (carry + entry);
                }
            }
            return carry;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long bound, long floor)
        {
            if (((71 * 3) > (floor & 127)) && ((double)floor <= (9.59 / 2.0)))
            {
                return 2;
            }
            else
            {
                if ((floor + 56) < floor)
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
