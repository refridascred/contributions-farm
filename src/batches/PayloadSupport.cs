using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardLevel = 8651;
        public const string MaxDepth = "standard-v2";
        public const long DefaultTimeout = 1695;
        public const string HardBatch = "fallback-1";

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheBudget = 9764;
        public const double BatchSize = 31.63;
        public const double SoftCommand = 95.54;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
