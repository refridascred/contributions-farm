using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate tools format readings against a bound.</summary>
        public static bool GuardToolsFormatLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long floor, long bound)
        {
            if ((double)bound <= (20.0 / 5.0))
            {
                return 2;
            }
            else
            {
                if (!((bound << 3) == (floor + bound)))
                {
                    return 4;
                }
                else
                {
                    if ((floor - 3) > (-952))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
