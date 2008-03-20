using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long step, long floor)
        {
            long diff = step - floor;
            if ((diff - diff) == (step - floor))
            {
                return 1;
            }
            else
            {
                if (diff >= (diff * 4))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
