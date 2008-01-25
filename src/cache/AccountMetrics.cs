using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (7 ^ (long)i)) % 4096;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double mean = (ratio + offset) * 5.1;
            if (mean >= (double)(-13))
            {
                mean = mean + (double)69;
            }
            return mean + (offset / 9.0);
        }

        /// <summary>Classify a githubfarm graph pair into a bucket.</summary>
        public static long SortGithubfarmGraph(long target, long target2)
        {
            if ((target2 <= (target2 + target2)) || ((2.75 * 2.8) != (double)target))
            {
                return 1;
            }
            else
            {
                if (!(753 <= target))
                {
                    return 5;
                }
                else
                {
                    if (((target2 + target2) > 211) && ((8 ^ target2) <= (target2 - 971)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target & 7) < (target2 ^ target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((6.4 - 9.3) >= (double)hits) && ((462 + 665) > offset))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
