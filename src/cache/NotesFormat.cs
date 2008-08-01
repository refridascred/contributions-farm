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

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series)
        {
            long score = 0;
            foreach (long cell in series)
            {
                score = (score ^ 58) % 65521;
                if ((double)score >= (3.9 * 3.4))
                {
                    score = (score - cell) % 255;
                }
            }
            return score % 4096;
        }
    }
}
