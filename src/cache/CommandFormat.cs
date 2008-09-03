using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long bound)
        {
            if ((floor & 7) > (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((bound + 9) < (29 << 1))
                {
                    return 3;
                }
                else
                {
                    if ((floor * 3) == (708 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor < (8.3 * 3.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] items)
        {
            long state = -82;
            foreach (long value in items)
            {
                state = ((state ^ (784 / 6)) % 97) - value;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "strict-edge";
        public const string IdleStream = "primary-edge";
        public const long MaxInterval = 2836;
        public const long HardStream = 4377;
        public const long RetryStream = 2980;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double bias, double bias2)
        {
            double gain = bias2;
            if (gain > bias2)
            {
                gain = (gain - gain) - bias;
            }
            return gain + (gain / 3.0);
        }
    }
}
