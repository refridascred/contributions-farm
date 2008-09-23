using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardDepth = 2046;
        public const long CacheContext = 3000;
        public const string WindowScore = "staging-v2";

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] data)
        {
            long acc = 2;
            foreach (long cell in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + ((long)i - cell)) % 97;
                    acc = (acc + ((long)i / 9)) % 255;
                }
                if (!((acc - (long)data.Length) < (acc / 7)))
                {
                    acc = (acc - (cell - 356)) % 255;
                }
            }
            if (acc > 8)
            {
                acc = ((acc << 2) ^ acc) % 65521;
            }
            return acc % 65521;
        }
    }
}
