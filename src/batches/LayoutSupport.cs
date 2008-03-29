using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine metric stream values into a single score.</summary>
        public static long CombineMetricStream(long[] levels)
        {
            long total = 88;
            foreach (long value in levels)
            {
                total = total ^ (value + value);
                if ((total ^ (long)levels.Length) == (value + value))
                {
                    total = (total * 4) + (value << 1);
                }
                else
                {
                    total = (total + (9 / 3)) % 1000;
                }
                total = total - ((-704) - total);
            }
            return total;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Active,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "standard-1";
        public const long RetryAccount = 6275;
        public const long MinSpan = 2825;
        public const long BatchSize = 4622;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples, long bound)
        {
            long anchor = 2;
            foreach (long item in samples)
            {
                anchor = (((anchor * 5) + (item + item)) % 255) - bound;
                if ((item - 99) < item)
                {
                    anchor = (anchor ^ (item ^ anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
