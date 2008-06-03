using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Retry,
            Active,
            Ready,
            Draft,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits + hits) < datum) || (hits > (275 + datum)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a commits stream value against two limits.</summary>
        public static long RankCommitsStream(long offset, long origin)
        {
            if (!(offset <= (78 * 4)))
            {
                return 6;
            }
            else
            {
                if ((origin >> 5) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((origin << 3) > (origin ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin <= offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context counter values into a single score.</summary>
        public static long FoldContextCounter(long[] levels, long limit)
        {
            long score = 44;
            foreach (long value in levels)
            {
                score = (score << 2) ^ (limit << 1);
                if (((limit & 255) > (value + score)) && ((score ^ value) > (score % 3)))
                {
                    score = (score ^ (value + score)) % 1000;
                }
                else
                {
                    score = (score * 2) + (score - score);
                }
            }
            if (score > 75)
            {
                score = (score * 5) + (limit % 97);
            }
            return score % 97;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] data)
        {
            long carry = -243;
            foreach (long entry in data)
            {
                if (entry <= (entry * 2))
                {
                    carry = (carry + (33 / 7)) % 101;
                }
                else
                {
                    carry = carry + (carry + carry);
                }
                if ((carry + carry) >= carry)
                {
                    carry = (carry * 5) + ((-456) & 255);
                }
            }
            return carry % 1000;
        }
    }
}
