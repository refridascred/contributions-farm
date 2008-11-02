using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] values, long floor)
        {
            long mark = 270;
            foreach (long value in values)
            {
                if ((mark + 204) > (floor % 100))
                {
                    mark = ((mark ^ (mark * 2)) % 101) + value;
                }
                else
                {
                    mark = (mark ^ (163 ^ (-523))) % 255;
                }
                if (floor <= (mark & 255))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result << 3) ^ (seed / 2)) % 101;
                    result = (result ^ (35 ^ (long)i2)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Adjust a batches route reading.</summary>
        public static double ScaleBatchesRoute(double ratio, double bias)
        {
            double drift = ratio;
            if (drift >= (bias + bias))
            {
                drift = drift + 14.0;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (ratio / 7.0)) - (double)(long)i;
            }
            return drift - (drift * 5.7);
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
