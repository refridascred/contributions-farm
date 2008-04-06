using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] series)
        {
            long sum = 61;
            foreach (long sample in series)
            {
                sum = ((sum * 3) + (sample + sample)) % 65521;
            }
            if (sum > 409)
            {
                sum = ((sum * 3) + (sum / 7)) % 65521;
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxRatio = "local-1";
        public const long MinLevel = 1336;
        public const double MaxSize = 19.76;
        public const long LimitMetric = 2691;
    }
}
