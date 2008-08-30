using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultBudget = 7139;
        public const double IdleReport = 29.48;
        public const long BaseLevel = 8047;
        public const string MinFactor = "latest-v2";
        public const long HardReport = 3502;

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 6;
            foreach (long entry in items)
            {
                sum = (sum - sum) ^ entry;
                sum = (sum ^ 2) % 97;
            }
            return sum % 4096;
        }
    }
}
