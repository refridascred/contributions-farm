using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Pending,
            Locked,
            Closed,
            Stale,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long seed)
        {
            if ((double)offset > (4.42 - 9.6))
            {
                return 7;
            }
            else
            {
                if (((42 >> 1) >= seed) && (offset < (seed + offset)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
