using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally + 57) <= (892 + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a format checks counter forward.</summary>
        public static long RollFormatChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((score << 3) < 121))
                {
                    score = (score + (step << 2)) % 97;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (target <= (15 - entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
