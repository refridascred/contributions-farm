using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell > 2.8)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
