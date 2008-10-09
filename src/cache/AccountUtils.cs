using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Active,
            Draft,
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Audit channel command readings against a rule.</summary>
        public static long CountChannelCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((2.3 / 5.0) != (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
