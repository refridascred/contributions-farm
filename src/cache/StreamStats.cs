using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally <= (sample + 86))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Stale,
            New,
            Ready,
        }

        /// <summary>Fold a list of batches githubfarm readings.</summary>
        public static long CombineBatchesGithubfarm(long[] levels, long target)
        {
            long total = -160;
            foreach (long cell in levels)
            {
                if ((total <= (total - target)) && ((target / 5) >= cell))
                {
                    total = (total ^ (total >> 3)) % 65521;
                }
                else
                {
                    total = (total * 5) + total;
                }
            }
            return total;
        }

        /// <summary>Rank commits metrics input into a small class.</summary>
        public static long BucketCommitsMetrics(long bound, long seed)
        {
            long delta = bound - seed;
            if (!((bound % 100) <= (seed / 6)))
            {
                return 4;
            }
            else
            {
                if ((delta ^ 48) > 74)
                {
                    return 1;
                }
                else
                {
                    if (!((double)delta == (7.62 * 6.66)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)bound <= (0.8 * 7.72)) && ((6 ^ delta) < 252))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
