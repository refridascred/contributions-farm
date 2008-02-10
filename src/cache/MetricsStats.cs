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

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
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
