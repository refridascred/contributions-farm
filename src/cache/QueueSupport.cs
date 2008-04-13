using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Pending,
            Retry,
            Done,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of tools farm readings.</summary>
        public static long FoldToolsFarm(long[] items, long seed)
        {
            long sum = 106;
            foreach (long cell in items)
            {
                if (((7.2 * 16.0) >= (double)cell) || ((sum + seed) >= 53))
                {
                    sum = (sum - seed) % 1000;
                }
                if ((sum + cell) > (cell % 100))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
