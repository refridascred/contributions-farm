using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 1983;
        public const long HardCache = 2936;
        public const string StepCache = "open-v2";
        public const string LimitDepth = "latest-v2";
        public const string DefaultCache = "fallback-v2";

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Region { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double ratio = (weight / 6.0) * 0.7;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (ratio * 4.0);
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + 1) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
