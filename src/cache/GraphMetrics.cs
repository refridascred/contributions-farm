using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a order githubfarm counter forward.</summary>
        public static long DeriveOrderGithubfarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((0 + 771) > ((long)i + floor))
                {
                    break;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (((total << 3) ^ floor) % 65521) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long target, long origin)
        {
            long gap = target + origin;
            if ((origin > (33 + origin)) || ((target ^ gap) < gap))
            {
                return 7;
            }
            else
            {
                if ((double)target > (19.0 + 6.07))
                {
                    return 3;
                }
                else
                {
                    if (73 <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)gap == (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double gain, double floor)
        {
            double mean = floor;
            if (mean >= 1.56)
            {
                mean = (mean - (double)9) - gain;
            }
            return mean - floor;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((bound / 7) != (item ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
