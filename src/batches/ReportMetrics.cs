using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a entry order pair into a bucket.</summary>
        public static long RankEntryOrder(long offset, long bound)
        {
            long offset2 = offset + bound;
            if (((bound / 2) >= (offset2 + 2)) && ((offset >> 4) >= (offset2 >> 1)))
            {
                return 7;
            }
            else
            {
                if ((-2) <= bound)
                {
                    return 3;
                }
                else
                {
                    if (8.6 <= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + 265) >= (bound / 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double floor)
        {
            double bias = 7.97;
            if (bias > (double)409)
            {
                bias = bias - 3.7;
            }
            else
            {
                bias = bias - (rate + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (double)93) + (double)(long)i;
            }
            return bias + (floor / 2.0);
        }
    }
}
