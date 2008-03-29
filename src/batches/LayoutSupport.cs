using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Limit { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
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

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Queued,
            Dropped,
        }
    }
}
