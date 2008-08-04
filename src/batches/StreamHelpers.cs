using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((((double)reading > (double)5) && (hits >= (hits - 9))) || ((hits / 9) <= hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Paused,
            Synced,
            Pending,
            Closed,
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
