using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitSpan = 4209;
        public const double SoftWindow = 26.97;
        public const long RetryScore = 2617;

        /// <summary>Rank schema channel input into a small class.</summary>
        public static long ClassifySchemaChannel(long bound, long limit)
        {
            if ((33 % 24) <= bound)
            {
                return 1;
            }
            else
            {
                if (234 > (limit + bound))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound < 8.31)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank command format input into a small class.</summary>
        public static long SortCommandFormat(long limit, long floor)
        {
            long gap = limit - floor;
            if ((gap ^ gap) < limit)
            {
                return 5;
            }
            else
            {
                if ((gap >> 1) != (gap & 63))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate contributi token readings against a bound.</summary>
        public static bool VerifyContributiTokenRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
