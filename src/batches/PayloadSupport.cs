using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchCount = 3678;
        public const long LimitSize = 2572;
        public const long MaxChannel = 7967;
        public const double RetryBudget = 28.57;
        public const long BaseFactor = 9710;

        /// <summary>Count the checks already entries that pass the check.</summary>
        public static long TallyChecksAlreadyGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((entry / 4) >= 68) || !((double)seen < (4.0 - 1.8)))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
