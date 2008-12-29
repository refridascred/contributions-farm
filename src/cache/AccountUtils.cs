using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Active,
            New,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((389 & 1) == ((long)samples.Length - 225))
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
