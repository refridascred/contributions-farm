using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((seed ^ seed) > (matches & 127))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
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

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] samples, long limit)
        {
            long carry = 397;
            foreach (long sample in samples)
            {
                if ((-19) > (2 - carry))
                {
                    carry = ((((carry << 3) ^ 84) % 1000) ^ sample) - limit;
                }
            }
            return carry;
        }
    }
}
