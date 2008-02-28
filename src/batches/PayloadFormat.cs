using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long bound, long limit)
        {
            long prev = bound - limit;
            if (((bound + bound) > (limit * 3)) || ((9.2 + 17.0) >= (double)limit))
            {
                return 3;
            }
            else
            {
                if ((double)limit < (double)985)
                {
                    return 6;
                }
                else
                {
                    if ((3.04 + 6.0) <= (double)prev)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate session order readings against a bound.</summary>
        public static bool ValidateSessionOrderRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count route commits pairs that satisfy a relation.</summary>
        public static long PairRouteCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 30;
        public const string BaseRecord = "standard-v2";
        public const double IdleLevel = 89.61;
        public const long BurstRecord = 5422;
    }
}
