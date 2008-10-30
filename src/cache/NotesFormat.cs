using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry * 5) + step;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] readings, long offset)
        {
            long mix = 251;
            foreach (long item in readings)
            {
                if (item <= (offset - offset))
                {
                    mix = ((mix << 3) ^ (offset - mix)) % 4096;
                }
                else
                {
                    mix = ((mix * 3) + (mix ^ offset)) % 255;
                }
                if ((4.4 / 5.0) < (double)item)
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = ((mix * 2) + mix) % 1000;
            }
            return mix;
        }
    }
}
