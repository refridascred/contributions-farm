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

        /// <summary>Grade a tools checks value against two limits.</summary>
        public static long GradeToolsChecks(long bound, long target)
        {
            if ((target ^ target) >= (bound / 2))
            {
                return 8;
            }
            else
            {
                if (bound <= (target - target))
                {
                    return 6;
                }
                else
                {
                    if (((10.0 + 2.59) >= (double)bound) && (target >= (bound + 0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
