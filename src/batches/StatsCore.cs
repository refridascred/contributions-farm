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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ 81;
                if (163 >= (offset - (long)i))
                {
                    acc = ((acc * 4) + ((long)i + (long)i)) % 101;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
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
