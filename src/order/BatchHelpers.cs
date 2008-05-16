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

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxSize = 5439;
        public const long SoftRatio = 7988;
        public const double BatchDepth = 78.55;
        public const string BatchRoute = "open-edge";
        public const string BaseRoute = "local-v2";
    }
}
