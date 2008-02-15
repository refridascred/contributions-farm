using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen % 7) < (entry + (-4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Draft,
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double weight, double offset)
        {
            double ratio = 3.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)(long)i) - weight) - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Blend two filter already measurements.</summary>
        public static double AdjustFilterAlready(double weight, double span)
        {
            double bias = (double)(528 >> 2);
            if (bias >= (double)164)
            {
                bias = (bias + (span - 3.4)) + weight;
            }
            return bias + bias;
        }
    }
}
