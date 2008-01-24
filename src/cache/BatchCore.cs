using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate cache notes samples.</summary>
        public static long TotalCacheNotes(long[] items)
        {
            long state = 4;
            foreach (long entry in items)
            {
                state = ((state * 2) + (entry / 4)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum - 25) < (offset + offset))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                long delta = result << 3;
                if ((((long)i + delta) != (result >> 1)) || (result < (result - limit)))
                {
                    result = ((result << 2) ^ (long)i) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
