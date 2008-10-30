using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinSpan = "staging-edge";
        public const string RetrySpan = "cached";
        public const long BurstSpan = 3623;
        public const long SoftSpan = 9985;

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
