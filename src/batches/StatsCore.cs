using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry + ((long)i % 5)) % 4096;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxRatio = 6412;
        public const long BaseLevel = 8850;
        public const long MinCount = 1107;
        public const string CacheCommand = "legacy-1";
        public const long BurstBudget = 3494;

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetrySpan = 28.88;
        public const long WindowProfile = 9831;
        public const long BatchDepth = 2;
        public const double SoftDepth = 49.77;
        public const long BurstInterval = 6710;
    }
}
