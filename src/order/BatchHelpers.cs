using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up buffer stream samples.</summary>
        public static long CompareBufferStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftWidth = 4648;
        public const long LimitSize = 2812;
        public const double MinFactor = 95.63;
        public const long DefaultSpan = 5157;
        public const string MaxQueue = "latest-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitScore = 4635;
        public const long CacheFactor = 2447;
        public const long MaxSupport = 4177;
    }
}
