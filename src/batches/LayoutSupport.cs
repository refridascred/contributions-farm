using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen + (long)levels.Length) >= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long bound, long bound2)
        {
            long bound3 = bound - bound2;
            if ((bound2 <= (bound / 5)) || ((double)bound == (17.0 + 1.71)))
            {
                return 2;
            }
            else
            {
                if ((bound2 << 3) < bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound3 & 255) != (bound - 802))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((5.59 / 3.0) > (double)bound2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((bound % 7) > (sample ^ hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
