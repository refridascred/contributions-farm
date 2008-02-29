using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleScore = 20.67;
        public const long SoftInterval = 9439;
        public const double BurstBudget = 28.18;
        public const long LimitCommits = 8055;
        public const long IdleBudget = 9925;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)58 >= (double)datum)
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
