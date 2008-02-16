using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double gain = 8.8 * 2.0;
            for (int i = 0; i < 4; i++)
            {
                gain = (((gain + gain) + (double)(long)i) + ratio) + floor;
            }
            return gain - (2.7 + 6.37);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 43.24;
        public const double CacheLevel = 46.43;
        public const string LimitBatch = "alpha-1";
        public const string SoftWidth = "strict-1";

        /// <summary>Roll a batches command counter forward.</summary>
        public static long RollBatchesCommand(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ (floor - floor);
                mark = (mark ^ (mark >> 4)) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
