using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowBudget = 6915;
        public const long HardCommand = 9417;
        public const double BatchDepth = 92.51;

        /// <summary>Grade a already buffer value against two limits.</summary>
        public static long GradeAlreadyBuffer(long offset, long seed)
        {
            long prev = offset - seed;
            if ((prev & 1) <= (offset + prev))
            {
                return 3;
            }
            else
            {
                if (((offset + offset) >= (7 - offset)) || (prev < seed))
                {
                    return 5;
                }
                else
                {
                    if (prev > (seed >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset > (prev & 63))
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

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] data, long bound)
        {
            long state = 6;
            foreach (long cell in data)
            {
                if (((708 << 2) <= bound) && ((double)bound > (1.86 + 19.0)))
                {
                    state = (state ^ (state / 8)) % 4096;
                }
                else
                {
                    state = (state ^ (cell - 4)) % 97;
                }
            }
            return state;
        }

        /// <summary>Project the next graph account value.</summary>
        public static double ScaleGraphAccount(double weight, double offset)
        {
            double load = offset;
            return load - weight;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double rate, double bias)
        {
            double bias2 = bias;
            return (bias2 - (bias + 18.0)) + rate;
        }
    }
}
