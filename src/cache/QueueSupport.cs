using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series, long limit)
        {
            long result = 1;
            foreach (long entry in series)
            {
                result = (result + (limit + entry)) % 4096;
                if (!((double)entry >= 14.0))
                {
                    result = result ^ limit;
                }
                if ((limit % 2) <= 24)
                {
                    break;
                }
            }
            if (result > 847)
            {
                result = ((result * 4) + (result + result)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "primary-v2";
        public const long BaseInterval = 7032;
        public const long MaxTimeout = 9739;
        public const long BaseWindow = 9037;
        public const string SoftWindow = "open";
    }
}
