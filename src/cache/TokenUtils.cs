using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long bound)
        {
            if ((double)bound == (7.0 / 4.0))
            {
                return 6;
            }
            else
            {
                if ((step * 5) >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound >= (bound * 3)) && ((bound - step) == (step / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((519 + bound) > (step + 742))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long origin, long bound)
        {
            long gap = origin + bound;
            if ((gap + (-62)) > (21 + gap))
            {
                return 6;
            }
            else
            {
                if (2.0 <= (double)gap)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Active,
            New,
            Retry,
            Failed,
        }
    }
}
