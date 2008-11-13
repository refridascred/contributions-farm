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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((8.1 * 3.3) <= (double)seen)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
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
