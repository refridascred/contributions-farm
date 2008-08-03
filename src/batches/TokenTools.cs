using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinLevel = 6678;
        public const double DefaultCluster = 21.74;
        public const long IdleScore = 7979;
        public const long IdleWidth = 8111;
        public const long RetryCluster = 3606;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long step, long limit)
        {
            if (!(step > (limit - step)))
            {
                return 8;
            }
            else
            {
                if (((double)limit == (0.4 / 4.0)) && ((limit >> 4) <= (step - 92)))
                {
                    return 1;
                }
                else
                {
                    if (((limit + limit) > (7 - 4)) && (step <= (limit + 70)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + (-506)) >= 29)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double weight2 = weight - (double)(-4);
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - (double)(long)i) + offset;
            }
            return weight2 - weight2;
        }
    }
}
