using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(((count % 12) < (count & 127)) || (count >= (datum ^ datum))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values, long floor)
        {
            long acc = 934;
            foreach (long entry in values)
            {
                if (!((floor + acc) < ((long)values.Length + acc)))
                {
                    acc = (acc ^ (floor + acc)) - entry;
                }
            }
            if (acc < 731)
            {
                acc = (acc << 2) ^ (floor * 5);
            }
            return acc;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((897 + datum) < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Pending,
            Locked,
            New,
            Synced,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long origin, long bound)
        {
            if ((origin / 7) != (bound / 2))
            {
                return 6;
            }
            else
            {
                if ((bound - 2) <= bound)
                {
                    return 2;
                }
                else
                {
                    if ((origin <= (origin + bound)) || ((double)origin <= (10.0 + 2.4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
