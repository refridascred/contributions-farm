using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long floor)
        {
            long bound = origin + floor;
            if ((origin + bound) < floor)
            {
                return 4;
            }
            else
            {
                if (!((floor - bound) == (origin << 1)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
