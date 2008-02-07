using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 2699;
        public const string StepTimeout = "local";
        public const string BaseCounter = "primary";
        public const double SoftCount = 24.93;

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count & 255) > (datum * 5))
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

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
        }
    }
}
