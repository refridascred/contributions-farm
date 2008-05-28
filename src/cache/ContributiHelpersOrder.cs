using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 2212;
        public const long DefaultLayout = 2491;
        public const long BatchSize = 3757;
        public const double BatchLayout = 35.72;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum - tally) > (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long limit, long target)
        {
            long edge = limit ^ target;
            if (edge < (edge * 5))
            {
                return 7;
            }
            else
            {
                if (edge > (limit << 3))
                {
                    return 4;
                }
                else
                {
                    if (target >= edge)
                    {
                        return 3;
                    }
                    else
                    {
                        if (target <= (limit + limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
