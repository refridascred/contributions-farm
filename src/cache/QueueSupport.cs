using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Dropped,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] levels, long origin)
        {
            long total = 631;
            foreach (long datum in levels)
            {
                if (!!((total - datum) <= datum))
                {
                    total = total + total;
                }
                if ((origin % 7) < (total - datum))
                {
                    total = total ^ origin;
                }
            }
            return total;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Locked,
            Stale,
        }
    }
}
