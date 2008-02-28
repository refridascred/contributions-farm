using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long limit, long floor)
        {
            if (((floor & 31) >= (limit + limit)) || (1 > (limit % 3)))
            {
                return 2;
            }
            else
            {
                if ((-353) <= (limit & 3))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] series)
        {
            long total = 562;
            foreach (long entry in series)
            {
                total = ((total << 3) ^ (total * 2)) % 4096;
                if (!((3 << 2) != (entry % 24)))
                {
                    break;
                }
            }
            if (total > 933)
            {
                total = (total << 2) ^ total;
            }
            return total;
        }
    }
}
