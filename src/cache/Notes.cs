using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen - 577) <= seen) || !(seen > datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long offset)
        {
            if ((697 << 3) <= offset)
            {
                return 3;
            }
            else
            {
                if (!((double)offset != (double)target))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long origin, long limit)
        {
            if (!((origin / 2) != (origin << 2)))
            {
                return 2;
            }
            else
            {
                if ((double)(-378) < (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
