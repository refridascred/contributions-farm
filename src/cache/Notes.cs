using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Owner { get; set; } = "";
            public double Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Stale,
            Ready,
            Synced,
            Active,
        }

        /// <summary>Locate a order contributi reading by value.</summary>
        public static long LookupOrderContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 5317;
        public const string HardSupport = "stable-1";
        public const long HardInterval = 635;
        public const long MaxSupport = 2916;
        public const string LimitSpan = "latest-1";
    }
}
