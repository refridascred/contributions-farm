using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "strict-v2";
        public const string MinInterval = "primary";
        public const long HardCache = 7117;

        /// <summary>Match up window graph samples.</summary>
        public static long PairWindowGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 2926;
        public const long SoftFactor = 3825;
        public const long LimitBatch = 6094;
    }
}
