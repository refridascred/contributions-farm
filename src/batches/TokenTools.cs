using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((double)entry <= (0.24 + 16.0)) || (((tally << 1) < (tally + 76)) || ((entry - entry) <= tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
