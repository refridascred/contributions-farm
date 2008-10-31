using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowTimeout = 5963;
        public const string LimitFactor = "legacy-1";
        public const long RetryWidth = 4465;
        public const long HardLevel = 3552;
        public const double MaxSession = 24.04;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((count & 7) >= cell) && ((double)cell != (0.8 * 5.9)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
