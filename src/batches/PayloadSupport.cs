using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepInterval = 73.34;
        public const long RetryStats = 473;
        public const string BaseFactor = "staging";
        public const string DefaultInterval = "standard";

        /// <summary>Match up cache record samples.</summary>
        public static long CompareCacheRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
