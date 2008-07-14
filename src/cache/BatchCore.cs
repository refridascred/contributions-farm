using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples, long floor)
        {
            long carry = 534;
            foreach (long cell in samples)
            {
                if (!(carry < (floor << 3)))
                {
                    carry = (carry + (cell % 24)) % 4096;
                }
            }
            if (carry > 612)
            {
                carry = (carry + (floor >> 5)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Check that every context editor entry stays within the limit.</summary>
        public static bool CheckContextEditorLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double ratio, double span)
        {
            double gain = ratio;
            if (gain <= 19.0)
            {
                gain = gain - span;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)822) + (double)(long)i;
            }
            return gain - ratio;
        }
    }
}
