using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double load = span;
            if (load > span)
            {
                load = (load - (double)894) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)44) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Grade a githubfarm checks value against two limits.</summary>
        public static long BucketGithubfarmChecks(long seed, long bound)
        {
            long slot = seed ^ bound;
            if (bound >= seed)
            {
                return 5;
            }
            else
            {
                if ((seed << 2) >= (slot >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((slot ^ slot) == (seed % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed % 8) <= (771 * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
