using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long offset)
        {
            long gap = floor - offset;
            if (!((9.13 / 7.0) <= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((86 - offset) != (gap % 10))
                {
                    return 1;
                }
                else
                {
                    if (!((7.81 - 10.0) <= (double)gap))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor * 3) < (floor - gap))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every order context entry stays within the limit.</summary>
        public static bool VerifyOrderContextRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
