using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long offset2)
        {
            if ((39 < (offset + offset)) || ((2.27 / 2.0) >= (double)offset2))
            {
                return 6;
            }
            else
            {
                if (((6.6 / 4.0) != (double)offset) || (offset2 < (offset2 + offset2)))
                {
                    return 4;
                }
                else
                {
                    if (((double)offset < 4.42) && ((offset ^ 246) != (offset2 ^ offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset % 64) < 13)
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

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > floor)
            {
                drift = drift - ratio;
            }
            return drift + (floor - floor);
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
