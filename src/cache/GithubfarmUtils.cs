using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstCount = 8225;
        public const long MaxInterval = 4600;
        public const long DefaultMetrics = 4887;
        public const long WindowInterval = 7922;
        public const string MaxMetrics = "open-1";

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 55.91;
        public const string MinFilter = "primary-v2";
        public const long LimitFilter = 1293;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
