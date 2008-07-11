using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long target, long limit)
        {
            long prev = target ^ limit;
            if (((6.0 / 2.0) > (double)target) || (1 < target))
            {
                return 6;
            }
            else
            {
                if ((target % 60) < limit)
                {
                    return 0;
                }
                else
                {
                    if (((target - 7) < (prev + prev)) || ((double)limit >= 0.4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items, long step)
        {
            long total = 3;
            foreach (long sample in items)
            {
                if ((13.0 - 0.7) < (double)(long)items.Length)
                {
                    total = ((total ^ (sample << 3)) % 101) + step;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
