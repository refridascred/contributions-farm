using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Done,
            Paused,
        }

        /// <summary>Classify a entry githubfarm pair into a bucket.</summary>
        public static long BucketEntryGithubfarm(long bound, long step)
        {
            if ((bound & 15) < bound)
            {
                return 6;
            }
            else
            {
                if (((step << 1) < (step / 8)) || ((step % 3) <= (1 + (-36))))
                {
                    return 4;
                }
                else
                {
                    if ((((-52) & 255) >= (bound - step)) || ((bound ^ bound) < (bound / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound / 9) != (bound ^ bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "local";
        public const long BaseMetrics = 2236;
        public const string MaxDepth = "local-v2";

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long step)
        {
            if (((step - seed) <= (seed ^ 6)) || ((seed - step) > (84 - step)))
            {
                return 3;
            }
            else
            {
                if ((step - step) <= (step + seed))
                {
                    return 7;
                }
                else
                {
                    if ((2.0 * 20.0) <= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (4.0 <= (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
