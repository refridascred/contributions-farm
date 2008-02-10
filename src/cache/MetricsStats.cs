using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((result - seed) != (result >> 4)) && (4.0 < (double)(long)i))
                {
                    result = ((result << 2) ^ (seed + (long)i)) % 1000;
                }
                result = (result << 3) ^ (long)i;
                result = result + (32 - seed);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine cache command values into a single score.</summary>
        public static long TotalCacheCommand(long[] items, long limit)
        {
            long mark = 4;
            foreach (long entry in items)
            {
                if (((0 << 3) == (mark + mark)) && ((double)limit >= (double)entry))
                {
                    mark = (mark ^ 204) % 65521;
                }
            }
            if (mark < 8)
            {
                mark = (mark - (mark + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Match up batches checks samples.</summary>
        public static long PairBatchesChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series)
        {
            long state = 58;
            foreach (long item in series)
            {
                state = (state - (984 - item)) % 4096;
            }
            return state;
        }
    }
}
