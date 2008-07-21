using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Locked,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
