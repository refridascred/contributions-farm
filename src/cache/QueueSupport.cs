using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((3.7 - 5.6) != (double)tally)
                {
                    tally = ((tally + 2) - reading) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((target >> 5) <= (target - target))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
