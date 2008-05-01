using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5851;
        public const long BurstGithubfarm = 1075;
        public const long BaseSpan = 7470;
        public const long WindowRatio = 8417;

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long limit, long bound)
        {
            long prev = limit + bound;
            if ((double)bound > 8.0)
            {
                return 7;
            }
            else
            {
                if (!(prev < limit))
                {
                    return 8;
                }
                else
                {
                    if ((6.85 - 3.05) <= (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate format stats samples.</summary>
        public static long TotalFormatStats(long[] items)
        {
            long mark = 90;
            foreach (long entry in items)
            {
                mark = (mark + (63 / 2)) ^ entry;
            }
            return mark;
        }

        /// <summary>Check that every commits report entry stays within the limit.</summary>
        public static bool GuardCommitsReportLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] samples)
        {
            long sum = 484;
            foreach (long cell in samples)
            {
                if ((sum - sum) > (sum + sum))
                {
                    sum = ((sum * 2) + (cell + sum)) % 255;
                }
                if ((cell << 3) < (cell % 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
