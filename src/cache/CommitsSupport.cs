using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((tally & 31) > (26 << 3)) && (((sample % 16) <= (sample >> 2)) || ((6.6 / 9.0) <= (double)tally)))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardWidth = 70.43;
        public const long BaseRecord = 5339;
        public const long BaseRatio = 6515;
        public const double IdleRecord = 89.47;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (4.76 / 7.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
