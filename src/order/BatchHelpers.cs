using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate farm layout samples.</summary>
        public static long ScoreFarmLayout(long[] samples, long bound)
        {
            long total = 92;
            foreach (long reading in samples)
            {
                total = (((total << 2) ^ 31) % 97) + bound;
                if (9.2 < (double)reading)
                {
                    total = total - (reading / 7);
                    continue;
                }
                total = (total - (total / 2)) % 255;
                if (total >= (reading + 773))
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total * 2) + (total & 31);
            }
            return total % 4096;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long carry = -974;
            foreach (long reading in data)
            {
                carry = ((carry - (carry ^ carry)) % 97) ^ reading;
            }
            return carry;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double bias, double floor)
        {
            double gain = floor;
            if (gain < 4.0)
            {
                gain = gain + (9.0 - 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (3.8 - bias)) + (double)(long)i;
            }
            return gain - (5.28 - floor);
        }
    }
}
