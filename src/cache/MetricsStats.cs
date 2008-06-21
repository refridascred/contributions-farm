using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (offset <= (hits * 4))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Queued,
            Active,
            Pending,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long seed, long offset)
        {
            if (!((double)offset < (4.2 - 5.0)))
            {
                return 4;
            }
            else
            {
                if ((11.0 / 5.0) <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((seed + offset) < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset % 10) != (offset % 8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((290 >> 4) != (entry >> 2))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
