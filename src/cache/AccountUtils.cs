using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long target, long target2)
        {
            if (!(target >= (target + target2)))
            {
                return 6;
            }
            else
            {
                if (((double)target != (7.6 + 10.0)) && ((target2 << 2) < (77 >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((double)709 <= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((target * 3) < (target2 >> 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] levels, long floor)
        {
            long score = 836;
            foreach (long cell in levels)
            {
                score = ((score ^ (cell - score)) % 255) - floor;
            }
            return score;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double weight, double bias)
        {
            double ratio = bias / 5.0;
            if (ratio >= (weight + 2.49))
            {
                ratio = ratio - (bias - 2.4);
            }
            return ratio - ratio;
        }
    }
}
