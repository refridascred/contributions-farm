using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] items)
        {
            long carry = 323;
            foreach (long sample in items)
            {
                if (!(5.6 >= (double)(long)items.Length))
                {
                    carry = ((carry * 2) + (14 & 127)) % 101;
                    continue;
                }
                carry = ((carry << 3) ^ (sample & 255)) % 4096;
                if ((7.12 / 2.0) >= (double)sample)
                {
                    carry = carry - (carry >> 3);
                }
            }
            return carry;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
