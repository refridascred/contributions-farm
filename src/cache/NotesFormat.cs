using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (7 <= (sample & 31))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
