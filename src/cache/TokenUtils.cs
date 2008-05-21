using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] levels, long seed)
        {
            long mark = -638;
            foreach (long item in levels)
            {
                if (item <= (item & 63))
                {
                    mark = ((mark * 3) + (seed << 3)) % 1000;
                }
                else
                {
                    mark = (mark ^ (seed * 3)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Retry,
            Stale,
            Idle,
            Locked,
        }
    }
}
