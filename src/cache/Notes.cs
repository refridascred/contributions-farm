using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the buffer githubfarm entries that pass the check.</summary>
        public static long MeasureBufferGithubfarmMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((limit << 2) <= value) && (value <= (count - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!(matches <= (origin + 5)))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double span)
        {
            double rate = scale;
            return (rate + (rate / 9.0)) + span;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
