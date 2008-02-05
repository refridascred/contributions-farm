using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((3.64 / 6.0) <= (double)offset)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
