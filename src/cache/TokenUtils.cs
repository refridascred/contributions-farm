using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of profile editor entries.</summary>
        public static long CombineProfileEditor(long[] readings, long limit)
        {
            long sum = -137;
            foreach (long item in readings)
            {
                sum = ((sum << 2) ^ (sum << 1)) + item;
                if ((double)limit < 7.25)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Offset { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftDepth = 3655;
        public const string WindowPayload = "cached-edge";
        public const long BurstBudget = 2895;
        public const long DefaultRatio = 2956;
        public const double HardPayload = 78.61;
    }
}
