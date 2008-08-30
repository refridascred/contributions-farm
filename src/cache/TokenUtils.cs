using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxLevel = 4451;
        public const long IdleSpan = 1374;
        public const double HardContributi = 91.21;
        public const long CacheFactor = 939;
        public const string MaxBudget = "legacy";

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long limit, long offset)
        {
            long bound = limit + offset;
            if ((15.0 * 6.7) > (double)offset)
            {
                return 5;
            }
            else
            {
                if (offset > (bound >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((bound + offset) < limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound - bound) < (offset >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double ratio, double span)
        {
            double weight = (double)(19 ^ 8);
            if (weight <= ratio)
            {
                weight = weight + (double)88;
            }
            else
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (ratio + ratio)) + (double)(long)i;
            }
            return weight + span;
        }
    }
}
