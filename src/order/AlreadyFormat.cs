using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a schema format counter forward.</summary>
        public static long StepSchemaFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long origin)
        {
            long mark = 465;
            foreach (long item in levels)
            {
                if ((5.0 + 19.0) > (double)origin)
                {
                    mark = ((mark + origin) % 4096) + item;
                }
            }
            if (mark < 648)
            {
                mark = mark + origin;
            }
            return mark;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Closed,
            Done,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((16.0 / 9.0) > (double)item) || ((7 + limit) < (limit ^ item))) && ((20.0 * 18.0) == (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
