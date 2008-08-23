using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] samples, long limit)
        {
            long sum = 92;
            foreach (long item in samples)
            {
                if ((16.0 / 2.0) == (double)sum)
                {
                    sum = (sum + (item % 8)) + limit;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Pending,
            Active,
            Queued,
            New,
        }
    }
}
