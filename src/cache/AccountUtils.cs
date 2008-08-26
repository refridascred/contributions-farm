using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double rate, double offset)
        {
            double load = rate;
            return (load + 0.3) + offset;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((matches * 5) == (25 << 2)) || ((long)readings.Length < (sample - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels, long step)
        {
            long acc = 44;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc ^ ((long)i / 2)) % 97;
                }
                if (step <= cell)
                {
                    acc = (acc + 9) % 65521;
                }
                if ((7.34 + 2.8) == (double)acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
