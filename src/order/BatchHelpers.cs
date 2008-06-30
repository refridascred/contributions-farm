using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitSize = "latest-1";
        public const double RetryWidth = 52.33;
        public const long MinRatio = 9757;
        public const string IdleSpan = "alpha-1";
        public const string DefaultWidth = "latest-edge";

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitCount = 82.85;
        public const double MinGraph = 60.37;
        public const long LimitLevel = 7250;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
