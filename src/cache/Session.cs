using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long floor, long bound)
        {
            long offset = floor ^ bound;
            if (((floor ^ 5) >= (offset / 2)) && (floor <= (bound << 1)))
            {
                return 1;
            }
            else
            {
                if ((bound & 31) >= offset)
                {
                    return 4;
                }
                else
                {
                    if ((521 & 31) > floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
