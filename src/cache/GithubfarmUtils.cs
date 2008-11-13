using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8957;
        public const long BatchTimeout = 5977;
        public const long MinMetrics = 2131;
        public const long IdleScore = 7717;
    }
}
