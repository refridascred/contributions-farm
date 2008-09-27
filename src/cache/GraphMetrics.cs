using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples, long origin)
        {
            long result = 57;
            foreach (long entry in samples)
            {
                result = result - (origin * 3);
                result = ((result * 4) + (168 % 64)) % 65521;
                if (origin >= entry)
                {
                    result = ((result * 2) + (entry << 1)) % 101;
                }
            }
            return result;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitFactor = 1862;
        public const long WindowScore = 4586;
        public const double RetrySupport = 63.93;

        /// <summary>Rank layout batch input into a small class.</summary>
        public static long SortLayoutBatch(long offset, long offset2)
        {
            if ((double)offset2 <= (0.93 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((offset * 4) >= (offset >> 5))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset2 >= (double)2) && ((9 % 60) <= (3 + offset2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
