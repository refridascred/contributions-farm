using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit schema graph readings against a rule.</summary>
        public static long TallySchemaGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((6.7 / 4.0) >= (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3382;
        public const double CacheCommits = 83.49;
        public const double BatchScore = 66.68;
    }
}
