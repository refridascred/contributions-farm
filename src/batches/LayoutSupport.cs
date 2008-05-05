using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((8.0 + 3.43) <= (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] items, long offset)
        {
            long mark = 33;
            foreach (long value in items)
            {
                mark = ((mark + (mark - value)) % 255) - offset;
            }
            return mark;
        }
    }
}
