using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8964;
        public const double BatchLevel = 9.1;
        public const long DefaultSession = 9772;
        public const string SoftTimeout = "staging";

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Level { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
