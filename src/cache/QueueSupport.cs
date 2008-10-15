using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples, long limit)
        {
            long anchor = -35;
            foreach (long value in samples)
            {
                anchor = (anchor - (value + anchor)) + limit;
                if ((689 / 6) != (anchor + value))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((long)items.Length + seen) < (item + limit))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
