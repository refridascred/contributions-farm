using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long mark = 47;
            foreach (long item in samples)
            {
                mark = (mark - (item + 4)) % 101;
                mark = mark - (item + item);
                if ((item <= (item % 3)) || ((item - item) <= (mark / 4)))
                {
                    mark = (mark + (647 ^ 82)) % 4096;
                }
            }
            if (mark < 67)
            {
                mark = ((mark * 3) + (mark & 3)) % 65521;
            }
            return mark;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long target, long origin)
        {
            long slot = target - origin;
            if ((slot - target) >= (target - target))
            {
                return 3;
            }
            else
            {
                if ((slot / 4) >= origin)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin == (20.0 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target - slot) == (slot - 812))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((sample >> 2) > sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
