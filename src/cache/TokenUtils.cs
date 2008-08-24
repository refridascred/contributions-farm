using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Pending,
            Locked,
            New,
            Queued,
        }

        /// <summary>Fold a list of route batch readings.</summary>
        public static long TotalRouteBatch(long[] readings)
        {
            long carry = 749;
            foreach (long item in readings)
            {
                carry = carry - (item ^ item);
                if (item >= carry)
                {
                    carry = carry + (item + item);
                }
            }
            return carry;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
