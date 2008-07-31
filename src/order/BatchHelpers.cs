using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((2.0 + 9.8) > (double)cell))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long floor, long target)
        {
            long step = floor - target;
            if ((7.01 * 6.4) != (double)floor)
            {
                return 5;
            }
            else
            {
                if ((step * 2) <= (target + floor))
                {
                    return 0;
                }
                else
                {
                    if (((68 * 3) >= step) || (floor < (floor & 31)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step / 5) <= (floor + floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
