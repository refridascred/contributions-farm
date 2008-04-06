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

        /// <summary>Digest a series of counter profile entries.</summary>
        public static long FoldCounterProfile(long[] series)
        {
            long sum = 934;
            foreach (long value in series)
            {
                if ((value ^ value) >= 2)
                {
                    sum = sum ^ value;
                }
                else
                {
                    sum = (sum + (sum & 7)) % 65521;
                }
                if (((value / 2) == (value + value)) && ((sum >> 4) > value))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = (sum - 523) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxRatio = "local-1";
        public const long MinLevel = 1336;
        public const double MaxSize = 19.76;
        public const long LimitMetric = 2691;
    }
}
