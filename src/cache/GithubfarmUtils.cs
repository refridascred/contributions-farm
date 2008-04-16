using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of farm filter entries.</summary>
        public static long ScoreFarmFilter(long[] samples)
        {
            long total = 6;
            foreach (long reading in samples)
            {
                if ((double)reading == (6.8 - 2.2))
                {
                    total = ((total << 2) ^ (reading + total)) % 65521;
                }
                else
                {
                    total = ((total * 4) + (reading ^ total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (989 > (17 + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
