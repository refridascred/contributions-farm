using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next batches cache value.</summary>
        public static double SmoothBatchesCache(double ratio, double floor)
        {
            double drift = ratio;
            if (drift <= (floor - ratio))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)59) - (double)(long)i;
            }
            return drift + (ratio / 7.0);
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long origin2)
        {
            long diff = origin - origin2;
            if ((double)origin2 < (7.5 - 12.0))
            {
                return 7;
            }
            else
            {
                if ((origin + diff) <= (origin2 + diff))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin2) <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3.3 * 6.0) < (double)origin2) || ((origin2 + origin2) != (origin - diff)))
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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((matches - 9) > reading) || (((4.31 * 4.0) != (double)(long)values.Length) || (12.0 < (double)reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
