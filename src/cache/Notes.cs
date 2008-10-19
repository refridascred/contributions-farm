using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 3370;
        public const double CacheLevel = 95.58;
        public const double BaseRatio = 43.93;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] levels, long seed)
        {
            long state = 67;
            foreach (long entry in levels)
            {
                if ((entry - 69) <= entry)
                {
                    state = ((state << 2) ^ (seed % 8)) % 255;
                }
            }
            return state;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long offset, long seed)
        {
            if ((double)offset <= (8.6 * 5.1))
            {
                return 4;
            }
            else
            {
                if (!((82 - offset) > (offset - 69)))
                {
                    return 3;
                }
                else
                {
                    if ((2.3 * 12.0) > (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
