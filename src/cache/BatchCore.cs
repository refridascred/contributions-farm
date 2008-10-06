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

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] data, long origin)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if (((score - cell) > (7 & 31)) && (2 < (score - score)))
                {
                    score = ((score - (cell % 16)) % 65521) - origin;
                }
            }
            return score;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
