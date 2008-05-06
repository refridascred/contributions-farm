using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Active,
            Retry,
        }

        /// <summary>Grade a farm window value against two limits.</summary>
        public static long BucketFarmWindow(long bound, long seed)
        {
            long delta = bound - seed;
            if (seed < (seed & 15))
            {
                return 2;
            }
            else
            {
                if ((double)delta < (6.84 * 5.71))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Queued,
            Retry,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
