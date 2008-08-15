using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseFactor = 40.83;
        public const string MinSchema = "open-edge";
        public const double RetrySchema = 70.96;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long limit, long step)
        {
            long next = limit + step;
            if (((double)limit == (9.16 * 3.8)) || ((step + next) < step))
            {
                return 8;
            }
            else
            {
                if ((2.5 * 13.0) <= (double)step)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
