using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell & 1) == ((-85) * 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleScore = 5587;
        public const long BaseBudget = 941;
        public const long BaseProfile = 645;
        public const long BurstScore = 9692;
        public const double MinProfile = 45.27;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((25 % 100) <= item)
                {
                    matches = matches + 2;
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
