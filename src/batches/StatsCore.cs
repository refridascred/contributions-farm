using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                long tally = (origin / 6) + state;
                state = (state ^ (origin + state)) % 255;
                state = (state - (tally + (long)i)) % 255;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many window counter samples are out of range.</summary>
        public static long CountWindowCounterMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 255) <= (offset % 64))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultTimeout = "alpha-1";
        public const double BurstBatch = 52.3;
        public const double SoftBatch = 24.4;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] levels, long limit)
        {
            long state = 379;
            foreach (long item in levels)
            {
                if ((369 + limit) <= (limit & 63))
                {
                    state = (((state * 4) + 1) % 97) + item;
                }
            }
            return state;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}
