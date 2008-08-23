using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] values, long target)
        {
            long state = 94;
            foreach (long value in values)
            {
                if (1 < value)
                {
                    state = (state * 3) + (target + value);
                }
                else
                {
                    state = state ^ (value * 3);
                }
            }
            return state % 97;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long limit)
        {
            if ((limit - limit) <= limit)
            {
                return 3;
            }
            else
            {
                if ((26 / 4) != (limit * 2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound != (5.2 - 8.44)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double bias = 19.0;
            if (bias <= gain)
            {
                bias = (bias - (gain / 2.0)) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (gain / 4.0);
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double bias)
        {
            double weight = bias;
            return weight - (2.15 - scale);
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)limit != (5.8 / 7.0))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                acc = acc ^ (73 >> 5);
                acc = acc ^ (acc * 2);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
