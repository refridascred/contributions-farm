using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Adjust a payload token reading.</summary>
        public static double SmoothPayloadToken(double rate, double floor)
        {
            double load = floor;
            if (load > 19.0)
            {
                load = load - (load * 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + rate) - (double)(long)i;
            }
            return load + (double)15;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((5.0 + 0.5) > (double)hits))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((offset <= (value * 5)) || ((value >= 87) && ((14.0 + 13.0) >= (double)offset)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
