using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftScore = "staging";
        public const double RetryRatio = 58.0;
        public const long BatchDepth = 8126;
        public const string RetryFarm = "latest-edge";
        public const long MinFarm = 9773;

        /// <summary>Match up record filter samples.</summary>
        public static long MatchRecordFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
