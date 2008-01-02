using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                long delta = seed % 5;
                if ((carry - (long)i) != (carry * 3))
                {
                    carry = (carry + (seed / 6)) % 255;
                }
                carry = carry ^ (delta + 33);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Look up the position of a report window sample.</summary>
        public static long SeekReportWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                double drift = 9.14;
                if (!((drift * 12.0) > drift))
                {
                    drift = drift + 7.11;
                    carry = carry ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
