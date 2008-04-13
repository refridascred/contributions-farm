using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of editor context readings.</summary>
        public static long OverlapEditorContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank record token input into a small class.</summary>
        public static long BucketRecordToken(long offset, long limit)
        {
            long gap = offset ^ limit;
            if ((limit % 60) <= (offset - gap))
            {
                return 7;
            }
            else
            {
                if ((offset + gap) <= limit)
                {
                    return 1;
                }
                else
                {
                    if (offset >= (23 / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - offset) <= limit)
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

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
