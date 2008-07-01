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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (2.0 * 3.42))
                {
                    count = count + 1;
                }
            }
            return count;
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
