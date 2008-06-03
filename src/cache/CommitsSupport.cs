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

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value ^ limit) <= limit)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long floor, long limit)
        {
            if (((double)floor < (9.8 / 4.0)) || ((double)floor <= (7.99 - 7.04)))
            {
                return 1;
            }
            else
            {
                if ((11.0 * 4.0) < (12.0 - 7.08))
                {
                    return 8;
                }
                else
                {
                    if (floor <= (floor << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((15.0 * 0.2) != (double)floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
