using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] levels, long origin)
        {
            long mark = -1;
            foreach (long entry in levels)
            {
                mark = (mark ^ (origin << 1)) ^ entry;
            }
            return mark;
        }
    }
}
