using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (17.0 - 4.98))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Check that every route record entry stays within the limit.</summary>
        public static bool VerifyRouteRecordRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long bound)
        {
            if ((bound - bound) < (offset - offset))
            {
                return 8;
            }
            else
            {
                if (!((bound * 3) < bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound * 5) < 46)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset >= 13.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
