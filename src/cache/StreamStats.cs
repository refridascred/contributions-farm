using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples)
        {
            long mark = 311;
            foreach (long item in samples)
            {
                mark = mark + (item / 7);
            }
            if (mark < 84)
            {
                mark = ((mark << 2) ^ (mark >> 4)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultSize = 2159;
        public const double MinAlready = 10.49;
        public const string RetryAlready = "primary-1";
        public const long BatchAlready = 6620;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
        }
    }
}
