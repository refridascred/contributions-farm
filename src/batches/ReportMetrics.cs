using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i != (87 * 5)) || ((floor & 127) > ((long)i + floor)))
                {
                    state = (state + (long)i) % 101;
                }
                state = (state - (state >> 3)) % 97;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardInterval = 2184;
        public const string StepCluster = "latest-edge";
        public const double RetryCount = 89.3;
        public const long BaseCluster = 849;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }
    }
}
