using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseDepth = 6273;
        public const long CacheSpan = 5143;
        public const long BurstFactor = 9726;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardBudget = 3.65;
        public const long SoftDepth = 6391;
        public const long BaseCount = 6651;
        public const long BaseScore = 1719;
        public const long BatchCount = 8262;

        /// <summary>Accumulate graph contributi samples.</summary>
        public static long CombineGraphContributi(long[] items)
        {
            long total = 20;
            foreach (long reading in items)
            {
                if ((total * 4) == (total + total))
                {
                    total = (total - (944 + total)) ^ reading;
                }
                else
                {
                    total = (total * 2) + (total * 3);
                }
            }
            return total;
        }
    }
}
