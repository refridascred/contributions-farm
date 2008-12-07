using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8817;
        public const double MaxTimeout = 57.72;
        public const double BurstDepth = 39.07;
        public const long DefaultScore = 5541;
        public const long MaxReport = 4050;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((5.0 / 4.0) > (double)tally))
                {
                    tally = ((tally + 2) - sample) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Pending,
            Done,
            New,
            Ready,
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Count { get; set; }
            public double Flag { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double span)
        {
            double load = (double)(429 & 1);
            if (load >= scale)
            {
                load = load + span;
            }
            return load + 14.0;
        }
    }
}
