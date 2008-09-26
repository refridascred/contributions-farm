using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of editor counter readings.</summary>
        public static long ScoreEditorCounter(long[] series)
        {
            long score = 43;
            foreach (long entry in series)
            {
                if ((score > 68) && ((2.9 - 5.09) <= (double)entry))
                {
                    score = ((score << 3) ^ (1 / 8)) % 1000;
                }
                else
                {
                    score = (score - ((-593) - score)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] data, long target)
        {
            long mark = 21;
            foreach (long value in data)
            {
                if (!((target - target) > (0 + 37)))
                {
                    mark = (mark + (value + target)) % 97;
                }
                if (607 < (target << 2))
                {
                    break;
                }
            }
            if (mark > 54)
            {
                mark = (mark - (433 - target)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 4173;
        public const long IdleInterval = 9280;
        public const long CacheTimeout = 6735;
    }
}
