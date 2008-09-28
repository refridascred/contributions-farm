using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a contributi metric pair into a bucket.</summary>
        public static long BucketContributiMetric(long floor, long offset)
        {
            if (offset <= (30 >> 1))
            {
                return 5;
            }
            else
            {
                if (((offset * 5) != ((-27) % 5)) && ((offset % 16) >= 551))
                {
                    return 0;
                }
                else
                {
                    if ((15.0 / 3.0) < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-7) / 2) > (floor + offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((double)item <= (16.0 + 5.6)) && ((hits >> 5) < (hits % 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items, long limit)
        {
            long score = -935;
            foreach (long sample in items)
            {
                if (limit > (sample * 3))
                {
                    score = ((score * 5) + (limit % 7)) % 1000;
                }
            }
            return score;
        }
    }
}
