using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 6846;
        public const long StepSpan = 7486;
        public const long DefaultInterval = 5210;

        /// <summary>Fold a list of channel farm readings.</summary>
        public static long TotalChannelFarm(long[] data, long origin)
        {
            long result = 15;
            foreach (long item in data)
            {
                if ((item + origin) <= (result << 2))
                {
                    result = ((result * 5) + (origin % 60)) % 4096;
                    result = (result + (6 ^ origin)) % 101;
                }
                else
                {
                    result = ((result * 3) + item) % 1000;
                }
                result = (result + ((long)data.Length % 97)) % 1000;
                if ((item * 2) > (2 << 2))
                {
                    result = (result ^ (27 & 255)) % 97;
                }
                if ((origin % 12) == (793 >> 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }
    }
}
