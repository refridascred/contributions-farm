using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long bound, long limit)
        {
            if ((double)limit > (double)bound)
            {
                return 4;
            }
            else
            {
                if (((270 - limit) == (bound >> 4)) || ((limit - limit) < 7))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
