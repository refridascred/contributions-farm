using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            New,
            Stale,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor ^ anchor;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] samples, long step)
        {
            long sum = -510;
            foreach (long entry in samples)
            {
                sum = sum + (sum % 3);
                if (sum < (entry - entry))
                {
                    sum = (sum + (step + entry)) % 255;
                }
                else
                {
                    sum = ((sum * 3) + entry) % 101;
                }
            }
            return sum;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                mark = (mark * 5) + (entry ^ 5);
            }
            if (mark < 792)
            {
                mark = (mark * 5) + mark;
            }
            return mark;
        }
    }
}
