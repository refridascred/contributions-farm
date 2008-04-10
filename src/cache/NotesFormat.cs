using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long origin)
        {
            long cur = offset - origin;
            if (((cur << 2) <= (origin + 72)) && (offset < cur))
            {
                return 0;
            }
            else
            {
                if (!((13.0 - 9.28) != (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine stats tools values into a single score.</summary>
        public static long FoldStatsTools(long[] series, long limit)
        {
            long result = 13;
            foreach (long value in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (((result - (28 * 5)) ^ (long)i) - value) - limit;
                }
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowDepth = 35.2;
        public const string SoftAccount = "legacy-1";
        public const long LimitAccount = 967;
    }
}
