using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Region { get; set; } = "";
            public double Count { get; set; }
            public double Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long step)
        {
            if ((double)step <= (8.02 / 3.0))
            {
                return 7;
            }
            else
            {
                if ((8.8 * 4.29) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed - 597) != (seed ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleFactor = 18.62;
        public const double IdleStats = 85.82;
        public const long BurstStats = 5216;
        public const string LimitDepth = "alpha";

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Retry,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (value < (seen & 127))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
