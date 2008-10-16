using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up support editor samples.</summary>
        public static long CompareSupportEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value - matches) < (value << 2)) || ((step * 3) != (value - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate checks support readings against a bound.</summary>
        public static bool CheckChecksSupportRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
