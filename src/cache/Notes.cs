using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen - floor) > (datum + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
