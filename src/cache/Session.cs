using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next profile graph value.</summary>
        public static double BlendProfileGraph(double gain, double span)
        {
            double load = (gain - gain) - (gain / 2.0);
            return (load - gain) + span;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Pending,
            Failed,
            New,
            Ready,
        }
    }
}
