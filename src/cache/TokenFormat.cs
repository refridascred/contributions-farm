using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = (total - (total * 3)) % 255;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (total - (total + target)) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double scale = (double)(17 ^ 9);
            if (scale < floor)
            {
                scale = (scale + (floor - 9.0)) + gain;
            }
            return scale + (double)74;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((count + count) <= 96) && ((value * 4) <= (value + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
