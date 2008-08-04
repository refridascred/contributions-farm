using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((tally + 94) >= 3))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long step)
        {
            long step2 = seed - step;
            if (!(step >= (step2 + 89)))
            {
                return 8;
            }
            else
            {
                if ((step + 927) < (step ^ step2))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed >= (3.8 - 12.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] levels, long limit)
        {
            long score = 290;
            foreach (long reading in levels)
            {
                if (limit > (limit >> 5))
                {
                    score = ((score << 3) ^ 5) + reading;
                }
                if (limit <= (limit - 6))
                {
                    break;
                }
            }
            if (score < 724)
            {
                score = ((score * 2) + (0 + score)) % 255;
            }
            return score % 97;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultScore = 95.83;
        public const long BurstSpan = 4828;
        public const string WindowSpan = "stable-1";

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((69 - 97) > reading)
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }
    }
}
