using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long bound)
        {
            if ((double)bound < (4.75 / 4.0))
            {
                return 0;
            }
            else
            {
                if (floor <= (bound << 3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Draft,
            Paused,
            Dropped,
            Failed,
        }
    }
}
