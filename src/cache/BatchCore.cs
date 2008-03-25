using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples)
        {
            long total = 69;
            foreach (long reading in samples)
            {
                total = (total - (total << 2)) ^ reading;
            }
            if (total < 7)
            {
                total = (total * 2) + 888;
            }
            return total;
        }

        /// <summary>Count the stats token entries that pass the check.</summary>
        public static long AuditStatsTokenOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((seen / 8) >= ((-91) + 759)))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
