using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 4474;
        public const long MinContext = 3537;
        public const long DefaultContext = 6867;
        public const long LimitInterval = 8379;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            New,
            Done,
        }
    }
}
