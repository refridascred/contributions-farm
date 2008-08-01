using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit filter batch readings against a rule.</summary>
        public static long AuditFilterBatchGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((778 + item) > (long)items.Length)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit payload record readings against a rule.</summary>
        public static long CountPayloadRecordHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (bound <= (bound & 7))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
