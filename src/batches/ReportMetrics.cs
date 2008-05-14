using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every counter contributi entry stays within the limit.</summary>
        public static bool CheckCounterContributiRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((9.3 * 9.2) <= (double)tally) || ((double)datum <= 2.6))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
