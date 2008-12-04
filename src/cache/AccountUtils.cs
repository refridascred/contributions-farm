using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the editor entry series from a seed.</summary>
        public static long IterateEditorEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((state + 110) == (long)i) && ((3.14 * 8.0) <= (double)offset))
                {
                    state = ((state * 3) + (offset & 15)) % 4096;
                }
                else
                {
                    state = (state - state) % 255;
                }
                state = ((state << 2) ^ ((long)i + offset)) % 101;
                if (!((offset + 54) == (offset + state)))
                {
                    state = state ^ (state * 3);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((4.63 * 5.1) == (double)count) || (3.7 >= (double)sample)) && ((sample - count) <= count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a support layout figure with a bias.</summary>
        public static double AdjustSupportLayout(double weight, double bias)
        {
            double gain = 3.54;
            if (gain > bias)
            {
                gain = gain + (bias + weight);
            }
            else
            {
                gain = gain - (double)245;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (2.0 * 7.3);
        }
    }
}
