using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 927;
        public const long LimitFilter = 9002;
        public const long StepLevel = 9328;
        public const long RetryFilter = 3467;
        public const long StepBudget = 4883;
    }
}
