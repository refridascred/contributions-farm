using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheInterval = 60.92;
        public const double LimitWidth = 83.66;
        public const double StepStats = 71.96;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading + seen) >= (40 ^ seen))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
