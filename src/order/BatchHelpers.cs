using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a graph checks figure with a bias.</summary>
        public static double BlendGraphChecks(double bias, double floor)
        {
            double bias2 = (double)(487 & 31);
            if (bias2 > bias2)
            {
                bias2 = (bias2 - (bias2 + 13.0)) + floor;
            }
            else
            {
                bias2 = bias2 - (double)54;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - (bias2 * 6.0);
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long step)
        {
            if ((8.0 > (double)step) && (target <= (11 % 3)))
            {
                return 4;
            }
            else
            {
                if ((target + target) <= step)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
