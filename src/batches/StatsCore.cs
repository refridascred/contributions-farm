using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                if ((carry * 5) == (datum + datum))
                {
                    carry = carry - (datum % 97);
                }
            }
            return carry;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Classify a report cache pair into a bucket.</summary>
        public static long ClassifyReportCache(long target, long floor)
        {
            if (((target >> 3) != (floor + floor)) && ((634 - 78) > (target - 4)))
            {
                return 3;
            }
            else
            {
                if ((0 + 320) == (target + 41))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor == (7.2 / 3.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((6 + entry) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the window stats entries that pass the check.</summary>
        public static long CountWindowStatsMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((337 >> 5) == (long)values.Length)
                {
                    hits = ((hits + 3) - value) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)floor == (14.0 + 4.0))
                {
                    hits = (hits + 2) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
