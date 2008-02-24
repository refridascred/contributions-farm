using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank tools already input into a small class.</summary>
        public static long BucketToolsAlready(long target, long target2)
        {
            long gap = target - target2;
            if ((4.1 + 0.85) <= (8.85 + 1.75))
            {
                return 5;
            }
            else
            {
                if ((target >> 1) > target)
                {
                    return 6;
                }
                else
                {
                    if ((double)gap != (double)target2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (20 <= (value % 100))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long bound)
        {
            if ((2.59 + 4.5) < (double)bound)
            {
                return 1;
            }
            else
            {
                if (((double)limit != (2.7 * 6.65)) && ((double)bound < (9.49 * 2.59)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            New,
            Closed,
            Ready,
            Stale,
        }
    }
}
