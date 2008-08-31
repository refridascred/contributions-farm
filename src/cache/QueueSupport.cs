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

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public bool Level { get; set; }
        }
    }
}
