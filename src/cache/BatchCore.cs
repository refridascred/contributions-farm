using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits ^ step) == (datum & 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Count { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every record channel entry stays within the limit.</summary>
        public static bool CheckRecordChannelLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
