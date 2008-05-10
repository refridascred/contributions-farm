using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine window counter values into a single score.</summary>
        public static long ScoreWindowCounter(long[] readings, long step)
        {
            long carry = 62;
            foreach (long item in readings)
            {
                carry = ((carry + (item << 1)) % 65521) + step;
            }
            if (carry < 30)
            {
                carry = ((carry * 3) + (carry << 1)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long step)
        {
            if ((double)step > (6.2 + 8.0))
            {
                return 8;
            }
            else
            {
                if (((limit % 10) > (step * 5)) && ((double)step == (2.95 * 7.82)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] samples, long floor)
        {
            long acc = -12;
            foreach (long value in samples)
            {
                if ((double)floor < (7.4 - 16.0))
                {
                    acc = (acc + (171 ^ value)) % 255;
                }
                if ((7.4 * 5.82) > (8.7 - 14.0))
                {
                    acc = acc - (acc >> 4);
                }
            }
            if (acc < 869)
            {
                acc = (acc ^ floor) % 255;
            }
            return acc % 1000;
        }
    }
}
