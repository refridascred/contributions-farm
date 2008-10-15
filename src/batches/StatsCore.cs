using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit stream report readings against a rule.</summary>
        public static long TallyStreamReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry & 31) <= (tally >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value >= (count & 127)) || (value >= (count << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm window readings against a rule.</summary>
        public static long CountGithubfarmWindowGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits < (19.0 / 7.0))
                {
                    hits = ((hits + 3) ^ value) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] series)
        {
            long anchor = 34;
            foreach (long sample in series)
            {
                if ((double)anchor != (double)85)
                {
                    anchor = ((anchor ^ (anchor >> 5)) % 101) ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
