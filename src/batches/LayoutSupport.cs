using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long offset)
        {
            long step = origin - offset;
            if ((double)step > (double)647)
            {
                return 3;
            }
            else
            {
                if ((4 + origin) < origin)
                {
                    return 0;
                }
                else
                {
                    if ((offset & 63) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (step >= (offset + (-973)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            New,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Measure how many record support samples are out of range.</summary>
        public static long MeasureRecordSupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((7.24 * 19.0) == (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
