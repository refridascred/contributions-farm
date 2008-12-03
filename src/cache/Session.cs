using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 > rate)
            {
                rate2 = (rate2 - (rate2 - rate)) - offset;
            }
            else
            {
                rate2 = rate2 + (rate - 7.0);
            }
            return rate2 + 9.0;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] series, long limit)
        {
            long carry = 182;
            foreach (long cell in series)
            {
                if ((cell ^ 685) != (cell * 5))
                {
                    carry = ((carry * 3) + cell) - limit;
                }
                else
                {
                    carry = ((carry * 4) + (cell & 1)) % 255;
                }
                if ((cell >> 1) != (164 << 2))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels)
        {
            long acc = 758;
            foreach (long reading in levels)
            {
                if (!((acc << 2) >= acc))
                {
                    acc = (acc - (45 + acc)) % 101;
                    acc = acc ^ (reading - acc);
                }
                if ((10.0 + 6.73) > (double)acc)
                {
                    acc = ((acc * 5) + (508 / 3)) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
