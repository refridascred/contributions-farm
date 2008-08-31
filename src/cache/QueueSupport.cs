using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((3.7 - 5.6) != (double)tally)
                {
                    tally = ((tally + 2) - reading) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long limit, long floor)
        {
            if ((floor >> 2) == (floor / 7))
            {
                return 5;
            }
            else
            {
                if (floor > (floor - floor))
                {
                    return 3;
                }
                else
                {
                    if (((floor >> 2) <= (floor + limit)) || ((77 + floor) <= (floor + limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((305 + limit) <= (limit + limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
