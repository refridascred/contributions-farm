using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 9831;
        public const long LimitEntry = 4933;
        public const long BatchSpan = 8798;

        /// <summary>Check that every checks queue entry stays within the limit.</summary>
        public static bool ValidateChecksQueueLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((matches >> 1) == (958 * 5)))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long floor, long seed)
        {
            if (floor > 6)
            {
                return 7;
            }
            else
            {
                if (((floor - seed) >= floor) && ((double)seed != (6.21 - 6.22)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
