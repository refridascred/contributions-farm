using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!!((entry - matches) == (matches / 9)))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long origin, long target)
        {
            if ((origin << 3) == (target & 255))
            {
                return 2;
            }
            else
            {
                if (target >= (target << 2))
                {
                    return 7;
                }
                else
                {
                    if ((target + origin) == (637 >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target >> 2) > target) && ((origin >> 2) <= (target / 7)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count record githubfarm pairs that satisfy a relation.</summary>
        public static long CompareRecordGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Paused,
            Dropped,
            Closed,
            Queued,
        }
    }
}
