using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Failed,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor layout value against two limits.</summary>
        public static long BucketEditorLayout(long step, long floor)
        {
            if ((floor ^ step) != (floor & 7))
            {
                return 7;
            }
            else
            {
                if ((8.0 * 4.5) <= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (step < (6 & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Failed,
            Ready,
            Active,
        }
    }
}
