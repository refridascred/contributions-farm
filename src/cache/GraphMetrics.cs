using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Active,
            Done,
            Retry,
            Paused,
        }

        /// <summary>Measure how many githubfarm counter samples are out of range.</summary>
        public static long AuditGithubfarmCounterGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!!((seen / 4) < bound))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            New,
            Retry,
            Ready,
            Idle,
        }
    }
}
