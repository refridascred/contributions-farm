using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] levels, long seed)
        {
            long anchor = 4;
            foreach (long reading in levels)
            {
                if ((8.41 - 8.0) <= (double)reading)
                {
                    anchor = ((anchor + (anchor % 7)) % 1000) + seed;
                }
                else
                {
                    anchor = (anchor + anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double floor)
        {
            double load = (bias + floor) - (bias * 8.73);
            return load + (double)(-5);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!(((980 + 67) != (sample * 5)) && ((2.8 / 4.0) == (double)sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
