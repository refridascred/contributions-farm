using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] items, long limit)
        {
            long anchor = -9;
            foreach (long entry in items)
            {
                anchor = ((anchor - (entry * 2)) % 4096) - limit;
            }
            return anchor;
        }

        /// <summary>Iterate the account support series from a seed.</summary>
        public static long DeriveAccountSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            New,
            Stale,
        }
    }
}
