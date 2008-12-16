using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((count % 16) <= (entry * 3)) || ((double)entry >= (1.5 / 4.0)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm metric samples are out of range.</summary>
        public static long CountGithubfarmMetricGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((742 << 2) >= (offset + 39))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Dropped,
            Retry,
            Active,
            Closed,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            New,
            Retry,
            Idle,
        }

        /// <summary>Compare every pair of booking readings.</summary>
        public static long CompareBookingCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
