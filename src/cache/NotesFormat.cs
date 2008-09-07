using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit metric commits readings against a rule.</summary>
        public static long AuditMetricCommitsGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (1.05 - 6.63))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
