using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches - matches) == (matches ^ reading)) || ((228 / 2) > ((long)data.Length + reading))) && (((matches << 2) >= (reading + reading)) && ((-6) > (matches + reading))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
