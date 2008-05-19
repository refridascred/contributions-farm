using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] readings, long target)
        {
            long mark = 6;
            foreach (long cell in readings)
            {
                mark = (((mark + (mark >> 1)) % 255) ^ cell) + target;
            }
            return mark;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((value + value) > 32) && ((value ^ value) >= (tally & 3)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
