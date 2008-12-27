using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Done,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Iterate the report stats series from a seed.</summary>
        public static long RollReportStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((limit / 5) == (limit + (long)i))
                {
                    total = (total * 3) + (long)i;
                }
                else
                {
                    total = (total << 3) ^ limit;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every batches checks entry stays within the limit.</summary>
        public static bool ValidateBatchesChecksRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
