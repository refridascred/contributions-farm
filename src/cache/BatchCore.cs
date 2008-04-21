using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every account notes entry stays within the limit.</summary>
        public static bool GuardAccountNotesLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry < (entry + count)) && ((entry ^ count) >= (entry + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
