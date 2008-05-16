using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitSize = 5709;
        public const string WindowFarm = "staging-edge";
        public const long MinFarm = 7677;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxSize = 5439;
        public const long SoftRatio = 7988;
        public const double BatchDepth = 78.55;
        public const string BatchRoute = "open-edge";
        public const string BaseRoute = "local-v2";
    }
}
