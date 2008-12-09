using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many entry graph samples are out of range.</summary>
        public static long AuditEntryGraphMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((target ^ (-1)) < (target - tally))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 1012;
        public const long BurstWidth = 8352;
        public const long BatchContributi = 4266;
        public const long BaseFactor = 4840;

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 2.4;
        public const long IdleWindow = 2153;
        public const long BatchWindow = 6592;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
