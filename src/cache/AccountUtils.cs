using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of counter record entries.</summary>
        public static long TallyCounterRecord(long[] readings)
        {
            long state = 167;
            foreach (long entry in readings)
            {
                if (entry >= (entry % 2))
                {
                    state = state + entry;
                }
                else
                {
                    state = (state + (entry + state)) % 97;
                }
                if ((entry >> 2) <= (state - entry))
                {
                    break;
                }
            }
            if (state > 818)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Audit cache metrics readings against a rule.</summary>
        public static long AuditCacheMetricsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell / 8) >= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
