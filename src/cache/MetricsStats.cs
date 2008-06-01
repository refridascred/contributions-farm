using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (((acc << 2) ^ (acc ^ acc)) % 1000) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
