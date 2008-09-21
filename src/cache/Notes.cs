using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long limit, long bound)
        {
            long slot = limit ^ bound;
            if ((1.05 + 14.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if ((double)0 >= (double)slot)
                {
                    return 5;
                }
                else
                {
                    if (slot >= (26 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long bound, long origin)
        {
            long delta = bound ^ origin;
            if ((double)bound != (5.3 + 7.1))
            {
                return 0;
            }
            else
            {
                if (!((bound << 3) == (origin ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if (0.62 < (double)delta)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            New,
            Stale,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
