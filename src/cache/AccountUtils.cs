using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Idle,
            New,
            Done,
            Active,
        }

        /// <summary>Rank editor schema input into a small class.</summary>
        public static long BucketEditorSchema(long floor, long seed)
        {
            long edge = floor ^ seed;
            if (!((floor / 6) >= floor))
            {
                return 4;
            }
            else
            {
                if (!((3 << 3) < edge))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
