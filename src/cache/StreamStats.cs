using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of payload cluster readings.</summary>
        public static long CombinePayloadCluster(long[] data)
        {
            long mark = 409;
            foreach (long datum in data)
            {
                mark = (mark ^ (mark + mark)) % 65521;
                if ((4.04 + 3.28) <= (double)datum)
                {
                    mark = mark ^ (datum + 93);
                }
            }
            if (mark < 78)
            {
                mark = (mark << 2) ^ (mark ^ 15);
            }
            return mark % 1000;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Ready,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultSupport = 28.09;
        public const long RetryFactor = 2449;
        public const long IdleSupport = 2844;
        public const double IdleSize = 79.24;

        /// <summary>Adjust a batches command reading.</summary>
        public static double ProjectBatchesCommand(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 - (bias * 2.2)) + weight;
            }
            return bias2 + (double)61;
        }
    }
}
