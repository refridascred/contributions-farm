using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long origin, long seed)
        {
            long cur = origin ^ seed;
            if ((cur - 599) > (origin << 2))
            {
                return 4;
            }
            else
            {
                if (!((seed % 100) >= (seed + seed)))
                {
                    return 2;
                }
                else
                {
                    if ((cur * 5) < ((-30) - cur))
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed > (seed >> 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long origin2)
        {
            long bound = origin + origin2;
            if ((863 / 2) >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin > 9.0)
                {
                    return 6;
                }
                else
                {
                    if (!(origin >= (origin2 - origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (4 >= (bound / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 2260;
        public const long StepContext = 4013;
        public const long WindowContext = 9263;
        public const long LimitDepth = 4150;
        public const long StepWidth = 6714;
    }
}
