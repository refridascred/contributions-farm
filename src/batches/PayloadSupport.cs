using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 86.05;
        public const double IdleLevel = 70.11;
        public const long BaseBatch = 5755;
        public const long MinSpan = 9957;
        public const long LimitScore = 8522;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
