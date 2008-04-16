using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading < (double)matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter editor entries.</summary>
        public static long ScoreFilterEditor(long[] items)
        {
            long mark = 421;
            foreach (long entry in items)
            {
                if (mark <= entry)
                {
                    mark = ((mark * 5) + (entry >> 2)) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long floor)
        {
            if (((limit - 29) != (limit * 5)) && ((double)limit >= 2.8))
            {
                return 1;
            }
            else
            {
                if (!((floor >> 4) != (floor & 3)))
                {
                    return 3;
                }
                else
                {
                    if (limit < (floor >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor > (8.0 * 4.64))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a githubfarm queue figure with a bias.</summary>
        public static double BlendGithubfarmQueue(double gain, double span)
        {
            double mean = (double)(8 % 16);
            if (mean <= 8.2)
            {
                mean = mean - (span + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (double)0;
        }
    }
}
