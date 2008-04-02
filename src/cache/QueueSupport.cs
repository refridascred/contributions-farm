using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long step, long offset)
        {
            if ((step % 12) == (offset - offset))
            {
                return 2;
            }
            else
            {
                if ((offset >> 3) <= (offset - step))
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
