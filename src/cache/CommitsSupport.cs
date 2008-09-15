using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftSize = 49.59;
        public const double MinDepth = 47.16;
        public const long SoftQueue = 798;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels, long origin)
        {
            long anchor = 72;
            foreach (long sample in levels)
            {
                if (origin >= (sample / 5))
                {
                    anchor = ((anchor * 2) + (anchor + origin)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many profile account samples are out of range.</summary>
        public static long TallyProfileAccountMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry < (count << 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long bound)
        {
            if ((bound + bound) != (0 * 3))
            {
                return 5;
            }
            else
            {
                if ((bound + floor) > (floor ^ bound))
                {
                    return 0;
                }
                else
                {
                    if ((floor << 2) > 4)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Weight { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }
    }
}
