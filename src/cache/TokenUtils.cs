using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next stream contributi value from a seed.</summary>
        public static long SeriesStreamContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit + limit) > ((long)i & 63))
                {
                    state = (state - (10 << 1)) % 101;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long acc = 47;
            foreach (long value in readings)
            {
                if ((double)acc != (6.28 * 4.1))
                {
                    acc = (acc + value) % 1000;
                }
                acc = (acc << 3) ^ (acc << 1);
                if ((2.0 + 11.0) >= (double)acc)
                {
                    acc = acc + ((long)readings.Length / 7);
                }
            }
            if (acc > 3)
            {
                acc = acc - (801 + acc);
            }
            return acc;
        }

        /// <summary>Project the next counter report value.</summary>
        public static double ScaleCounterReport(double gain, double span)
        {
            double mean = span;
            return (mean - span) + gain;
        }
    }
}
