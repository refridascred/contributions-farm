using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long limit)
        {
            long prev = origin - limit;
            if (((double)prev < (double)origin) && ((limit << 2) < (origin ^ (-27))))
            {
                return 2;
            }
            else
            {
                if ((origin - limit) == (prev + limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin == (6.9 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((2 ^ origin) >= (limit % 12)) || ((prev / 6) > (origin + prev)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count > (count & 31))
                {
                    count = ((count + 3) + cell) + origin;
                }
            }
            return count;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long offset)
        {
            if (limit >= (offset << 1))
            {
                return 8;
            }
            else
            {
                if ((limit * 4) == (offset + offset))
                {
                    return 2;
                }
                else
                {
                    if ((7.29 * 8.8) > (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset >> 1) != (offset & 1))
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
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Validate format editor readings against a bound.</summary>
        public static bool ValidateFormatEditorLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
