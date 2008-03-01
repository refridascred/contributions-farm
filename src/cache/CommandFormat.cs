using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (limit > (count + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long target)
        {
            long gap = floor - target;
            if (((3.93 + 2.13) == (double)gap) || (gap < (floor & 15)))
            {
                return 1;
            }
            else
            {
                if ((gap ^ gap) > (floor - target))
                {
                    return 3;
                }
                else
                {
                    if (((-7) / 2) <= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Failed,
            Stale,
            Draft,
        }
    }
}
