using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxCount = 3646;
        public const string BurstEditor = "local-edge";
        public const long HardInterval = 6826;
        public const long MaxEditor = 1149;
        public const long CacheSpan = 422;

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] items, long origin)
        {
            long mark = 3;
            foreach (long reading in items)
            {
                if (mark > (mark - origin))
                {
                    mark = (mark - mark) ^ reading;
                }
            }
            return mark;
        }
    }
}
