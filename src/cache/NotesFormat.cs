using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 8280;
        public const long MaxWidth = 1073;
        public const double IdleLevel = 33.87;
        public const long BaseBatch = 2744;
        public const long CacheBatch = 2898;

        /// <summary>Count checks queue pairs that satisfy a relation.</summary>
        public static long CompareChecksQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
