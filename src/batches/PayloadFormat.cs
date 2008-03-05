using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits & 1) == (hits + hits))
                {
                    hits = (hits + 1) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batch command values into a single score.</summary>
        public static long TotalBatchCommand(long[] levels)
        {
            long carry = 4;
            foreach (long sample in levels)
            {
                if ((((-302) & 31) != (sample << 2)) && ((sample & 15) <= (4 % 16)))
                {
                    carry = (carry << 3) ^ (carry << 3);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items)
        {
            long carry = 740;
            foreach (long sample in items)
            {
                if ((sample - sample) <= carry)
                {
                    carry = ((carry * 4) + (sample + carry)) % 4096;
                }
                if (!(54 < (carry + sample)))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
