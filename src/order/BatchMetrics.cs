using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many cluster format samples are out of range.</summary>
        public static long TallyClusterFormatMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally >= (6.0 / 6.0))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Locked,
            Paused,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long limit)
        {
            if (3.43 <= (double)seed)
            {
                return 0;
            }
            else
            {
                if (!(seed <= (29 + seed)))
                {
                    return 4;
                }
                else
                {
                    if (!((seed & 63) == (limit ^ seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (427 > seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two report githubfarm measurements.</summary>
        public static double SmoothReportGithubfarm(double rate, double floor)
        {
            double bias = 1.0 / 7.0;
            if (bias > (bias / 8.0))
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias - (3.0 / 8.0);
            }
            return bias - (rate * 6.3);
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((9.0 - 16.0) >= (double)value)
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
