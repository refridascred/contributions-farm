using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell >> 1) >= 0) || ((cell % 10) != (30 % 8)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Mode { get; set; }
            public double Label { get; set; }
        }
    }
}
