using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many checks batches samples are out of range.</summary>
        public static long MeasureChecksBatchesMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen << 2) != (seen & 15))
                {
                    seen = ((seen + 1) - value) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }
    }
}
