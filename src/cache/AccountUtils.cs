using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next notes command value from a seed.</summary>
        public static long StepNotesCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] series)
        {
            long acc = 90;
            foreach (long cell in series)
            {
                long cur = cell & 1;
                if ((5.5 / 6.0) == (double)cur)
                {
                    cur = (cur - (cell + acc)) % 101;
                }
                if (cell < (cell << 3))
                {
                    acc = ((acc * 4) + (acc * 5)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Check that every layout record entry stays within the limit.</summary>
        public static bool VerifyLayoutRecordLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
