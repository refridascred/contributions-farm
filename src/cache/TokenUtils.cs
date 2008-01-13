using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data)
        {
            long mark = 646;
            foreach (long value in data)
            {
                if (((mark << 3) <= (value - value)) && ((3.0 * 2.4) == (double)mark))
                {
                    mark = mark - ((long)data.Length % 7);
                }
                else
                {
                    mark = mark + (value + mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Derive the next payload token value from a seed.</summary>
        public static long StepPayloadToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)carry <= (double)(long)i))
                {
                    carry = (carry * 2) + origin;
                }
                if ((origin ^ 53) != (carry + 2))
                {
                    carry = (carry * 4) + (long)i;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Active,
            Stale,
            Dropped,
        }
    }
}
