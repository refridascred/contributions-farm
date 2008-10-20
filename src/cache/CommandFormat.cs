using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepTimeout = 957;
        public const long BaseBudget = 9332;
        public const long CacheBudget = 1016;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
