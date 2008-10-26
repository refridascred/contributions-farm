using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate filter record readings against a bound.</summary>
        public static bool CheckFilterRecordRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank stream farm input into a small class.</summary>
        public static long GradeStreamFarm(long limit, long offset)
        {
            if ((20.0 - 19.0) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (!((double)limit <= (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (limit < (limit ^ limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit < (4.0 * 2.6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Pending,
            Retry,
            Locked,
        }
    }
}
