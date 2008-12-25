using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long step, long step2)
        {
            if (7.2 >= (double)step)
            {
                return 4;
            }
            else
            {
                if (step2 >= (step2 - step))
                {
                    return 1;
                }
                else
                {
                    if (!((step & 255) < 75))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step & 3) <= (step2 + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long bound, long floor)
        {
            if (((floor >> 3) < (882 >> 3)) && (floor <= bound))
            {
                return 7;
            }
            else
            {
                if (!((double)floor < (double)814))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double mean = weight + (offset * 8.48);
            if (mean < (weight * 1.4))
            {
                mean = mean - offset;
            }
            return mean - (mean / 2.0);
        }
    }
}
