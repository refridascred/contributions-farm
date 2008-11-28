using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long limit, long seed)
        {
            long next = limit + seed;
            if (((48 - limit) != (seed / 8)) || ((double)next == (double)limit))
            {
                return 1;
            }
            else
            {
                if ((next > (limit & 255)) || (next <= (next >> 5)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 56.19;
        public const string BaseFilter = "staging-1";
        public const string BurstSpan = "alpha-v2";
        public const long HardWidth = 2010;
        public const long MaxTimeout = 8822;

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinTimeout = 12.63;
        public const double SoftFactor = 67.86;
        public const long BaseFarm = 3602;
    }
}
