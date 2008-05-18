using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (total * 2)) % 101;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long bound)
        {
            if (target > (target / 3))
            {
                return 0;
            }
            else
            {
                if ((double)target > (6.0 - 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((9.0 + 5.72) != (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound << 3) <= 90) && ((double)bound >= (7.76 * 10.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double mean = (span - weight) * 15.0;
            if (mean <= (double)22)
            {
                mean = mean + mean;
            }
            return mean + weight;
        }
    }
}
