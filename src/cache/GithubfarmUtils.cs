using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value & 127) < (value - limit))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long offset, long offset2)
        {
            if ((offset2 + 32) > offset2)
            {
                return 3;
            }
            else
            {
                if (!((offset2 - offset) >= offset2))
                {
                    return 5;
                }
                else
                {
                    if ((offset + offset) < 3)
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset >= (offset2 & 15))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate tools filter readings against a bound.</summary>
        public static bool ValidateToolsFilterLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
