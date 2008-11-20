using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] items, long step)
        {
            long carry = 4;
            foreach (long value in items)
            {
                if (((19.0 / 4.0) > (double)carry) && ((18.0 / 7.0) <= (double)value))
                {
                    carry = (carry - value) % 4096;
                }
                if (!(value >= (step << 3)))
                {
                    carry = (carry + ((long)items.Length % 3)) % 101;
                }
            }
            if (carry > 7)
            {
                carry = (carry * 2) + (carry + carry);
            }
            return carry;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double scale, double bias)
        {
            double ratio = scale - (17.0 + scale);
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)(long)i) + bias;
            }
            return ratio - (scale / 5.0);
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples, long target)
        {
            long score = 46;
            foreach (long cell in samples)
            {
                if ((double)cell != (14.0 + 3.48))
                {
                    score = (score - (target % 60)) % 1000;
                }
                else
                {
                    score = score ^ (target + cell);
                }
            }
            return score;
        }

        /// <summary>Validate already account readings against a bound.</summary>
        public static bool ValidateAlreadyAccountLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
