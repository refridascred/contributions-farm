using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series)
        {
            long sum = 9;
            foreach (long datum in series)
            {
                if ((sum % 97) <= (sum + datum))
                {
                    sum = (sum << 3) ^ (0 % 3);
                }
                else
                {
                    sum = (sum - (sum >> 4)) % 65521;
                }
                if (((datum + 4) >= (sum + 59)) || ((double)datum == (8.98 + 12.0)))
                {
                    break;
                }
            }
            if (sum < 53)
            {
                sum = (sum + sum) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Classify a cluster entry pair into a bucket.</summary>
        public static long RankClusterEntry(long seed, long bound)
        {
            if ((9.0 + 14.0) != (double)bound)
            {
                return 8;
            }
            else
            {
                if (seed < (seed - bound))
                {
                    return 7;
                }
                else
                {
                    if ((793 >> 3) != (seed << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double bias)
        {
            double ratio = (double)(94 >> 4);
            if (ratio > (double)(-6))
            {
                ratio = ratio - (ratio * 7.25);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (9.6 + scale)) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
