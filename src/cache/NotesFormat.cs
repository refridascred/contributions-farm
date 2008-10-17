using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window graph readings against a bound.</summary>
        public static bool CheckWindowGraphBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long origin2)
        {
            if ((70 % 16) == (origin2 + origin))
            {
                return 0;
            }
            else
            {
                if ((2.51 + 7.2) >= (double)origin2)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
