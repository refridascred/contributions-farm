using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((target & 31) >= matches)
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches >= ((-4) + matches))
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
            public bool Score { get; set; }
        }
    }
}
