using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count > (item + (-4))) && !((9 + count) <= (count >> 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((768 >> 5) >= (seen ^ sample))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
