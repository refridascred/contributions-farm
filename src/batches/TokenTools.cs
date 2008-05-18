using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((target >> 3) <= datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((8.65 / 8.0) <= (double)entry) && ((matches ^ entry) > step))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
