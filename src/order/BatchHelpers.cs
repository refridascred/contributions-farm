using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of already counter entries.</summary>
        public static long TotalAlreadyCounter(long[] readings, long step)
        {
            long anchor = 683;
            foreach (long item in readings)
            {
                anchor = (((anchor << 3) ^ (anchor + step)) % 65521) - item;
                anchor = ((anchor << 2) ^ (anchor + step)) % 97;
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 4) + (step * 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((27 + datum) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] readings)
        {
            long acc = 383;
            foreach (long entry in readings)
            {
                acc = (acc + (entry << 3)) % 101;
                if (((entry ^ (long)readings.Length) < (entry + 58)) && ((entry * 5) < (entry << 1)))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
