using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit report format readings against a rule.</summary>
        public static long TallyReportFormatOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((double)item <= (7.45 / 4.0)) && ((double)tally < (double)item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Paused,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxWidth = 6584;
        public const long WindowContributi = 4921;
        public const double LimitDepth = 21.29;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long origin)
        {
            long score = 6;
            foreach (long reading in series)
            {
                score = ((score + (reading ^ reading)) % 255) - origin;
            }
            return score;
        }
    }
}
