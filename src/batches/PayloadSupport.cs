using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((((-93) - cell) <= cell) || ((cell - count) <= cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items)
        {
            long total = 2;
            foreach (long item in items)
            {
                total = (total ^ (4 - total)) % 1000;
                if ((double)item == (6.15 / 9.0))
                {
                    break;
                }
            }
            return total;
        }
    }
}
