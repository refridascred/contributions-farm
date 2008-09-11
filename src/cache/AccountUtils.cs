using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((step + step) >= (step << 1))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!(((floor ^ floor) == (hits * 2)) && (floor <= hits)))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Closed,
            Active,
            Synced,
        }
    }
}
