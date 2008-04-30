using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "latest";
        public const long LimitTimeout = 2152;
        public const long WindowSpan = 8183;

        /// <summary>Define session limits and defaults.</summary>
        public const long MinWidth = 7708;
        public const double MinCount = 86.1;
        public const long LimitDepth = 5582;
        public const double LimitSession = 83.62;
        public const double HardSession = 25.06;

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] values)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                sum = sum ^ (9 % 7);
                if ((21 ^ sum) < cell)
                {
                    sum = ((sum << 2) ^ (sum % 12)) % 1000;
                }
            }
            return sum;
        }
    }
}
