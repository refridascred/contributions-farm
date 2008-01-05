using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitWidth = 6621;
        public const long MinBudget = 451;
        public const string BaseChannel = "legacy-edge";
        public const long BaseScore = 2323;
        public const double CacheBudget = 14.96;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading >= (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] items, long step)
        {
            long total = 53;
            foreach (long reading in items)
            {
                if ((step << 1) <= total)
                {
                    total = (total ^ step) + reading;
                }
            }
            if (total < 47)
            {
                total = (total * 2) + step;
            }
            return total;
        }
    }
}
