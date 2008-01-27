using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 69.26;
        public const string DefaultDepth = "fallback-1";
        public const string MinBudget = "primary-edge";
        public const string RetryChannel = "standard";
        public const long IdleChannel = 1354;

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 5704;
        public const string HardCommand = "alpha-1";
        public const long MinSize = 1357;
        public const double StepCommand = 17.67;
        public const double BaseFactor = 95.55;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values)
        {
            long carry = -29;
            foreach (long item in values)
            {
                if (carry >= (carry << 2))
                {
                    carry = (carry ^ (item * 3)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the report session entries that pass the check.</summary>
        public static long CountReportSessionMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (7.32 / 7.0))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
