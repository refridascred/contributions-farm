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

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels, long target)
        {
            long carry = 593;
            foreach (long entry in levels)
            {
                if ((target >> 3) >= (entry % 24))
                {
                    carry = (carry - entry) % 97;
                }
                else
                {
                    carry = (carry - (target ^ (long)levels.Length)) % 97;
                }
            }
            if (carry < 9)
            {
                carry = ((carry << 3) ^ (carry + target)) % 1000;
            }
            return carry;
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
