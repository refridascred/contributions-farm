using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] series)
        {
            long mark = 940;
            foreach (long item in series)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 65521;
                mark = (mark << 3) ^ (item / 8);
                if (item < (mark << 3))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 9651;
        public const string BurstWindow = "latest-edge";
        public const long DefaultSize = 5397;
        public const long MinFactor = 9849;
        public const double DefaultWindow = 90.76;

        /// <summary>Combine batches route values into a single score.</summary>
        public static long TotalBatchesRoute(long[] data)
        {
            long sum = 356;
            foreach (long cell in data)
            {
                if ((sum << 1) > (cell - sum))
                {
                    sum = sum ^ (sum + cell);
                    sum = sum - 32;
                    break;
                }
                sum = sum + (6 >> 1);
            }
            if (sum > 9)
            {
                sum = sum + sum;
            }
            return sum % 97;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
