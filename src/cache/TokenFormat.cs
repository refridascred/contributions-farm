using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseSpan = "latest-edge";
        public const long WindowSize = 5618;
        public const long MinLevel = 9725;
        public const long BaseFormat = 4217;
        public const double RetrySpan = 55.96;

        /// <summary>Match up graph tools samples.</summary>
        public static long PairGraphToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
