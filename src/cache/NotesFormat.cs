using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
