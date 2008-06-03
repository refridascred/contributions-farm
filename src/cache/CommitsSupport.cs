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

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleTimeout = 59.19;
        public const long BaseSpan = 6374;
        public const long BatchScore = 8430;
        public const long BatchReport = 9981;

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

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
