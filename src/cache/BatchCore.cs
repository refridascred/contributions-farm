using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftCount = 5803;
        public const long MaxDepth = 7839;
        public const long CacheCount = 4528;
        public const long DefaultStats = 5213;

        /// <summary>Combine layout account values into a single score.</summary>
        public static long FoldLayoutAccount(long[] data)
        {
            long mark = 63;
            foreach (long cell in data)
            {
                mark = ((mark << 2) ^ (mark << 1)) + cell;
            }
            return mark;
        }

        /// <summary>Iterate the format cache series from a seed.</summary>
        public static long SeriesFormatCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = score ^ (offset - offset);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
