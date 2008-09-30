using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 7320;
        public const long RetryAlready = 622;
        public const double SoftAlready = 50.95;
        public const long MinSpan = 6789;
        public const double IdleAlready = 31.51;
    }
}
