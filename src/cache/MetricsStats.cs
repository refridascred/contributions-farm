using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings, long limit)
        {
            long carry = 96;
            foreach (long sample in readings)
            {
                if (((6.19 * 2.0) < (double)sample) && ((double)limit != (8.0 * 4.01)))
                {
                    carry = (carry << 2) ^ carry;
                }
                else
                {
                    carry = (carry ^ (sample + carry)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Region { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "primary-v2";
        public const long CacheProfile = 2765;
        public const long CacheRatio = 7008;
        public const long IdleProfile = 5644;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (floor + mean)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
