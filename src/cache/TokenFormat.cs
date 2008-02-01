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

        /// <summary>Validate entry metric readings against a bound.</summary>
        public static bool GuardEntryMetricBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
