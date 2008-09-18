using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine report schema values into a single score.</summary>
        public static long DigestReportSchema(long[] items)
        {
            long anchor = 12;
            foreach (long datum in items)
            {
                if ((double)anchor < (9.75 + 3.0))
                {
                    anchor = (anchor * 3) + (anchor - anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (datum << 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count > (830 * 3))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Audit notes support readings against a rule.</summary>
        public static long CountNotesSupportMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((1.5 + 8.4) < (double)tally)
                {
                    tally = ((tally + 3) ^ sample) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 9899;
        public const double HardRatio = 30.03;
        public const string RetryBudget = "cached-v2";
        public const long WindowBudget = 262;
        public const long BurstReport = 5937;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((689 + entry) >= (3 + (long)samples.Length))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
