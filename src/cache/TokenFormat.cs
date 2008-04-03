using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length * 2) <= (174 - item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a tools githubfarm pair into a bucket.</summary>
        public static long RankToolsGithubfarm(long bound, long limit)
        {
            if ((limit + bound) >= (limit % 100))
            {
                return 2;
            }
            else
            {
                if (((limit - 59) == (bound ^ bound)) && ((2.4 / 5.0) > (double)limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit + bound) == (bound % 60))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit - limit) <= (limit / 8))
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

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Locked,
            Ready,
            Paused,
        }
    }
}
