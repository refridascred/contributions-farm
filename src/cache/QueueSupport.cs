using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a command queue value against two limits.</summary>
        public static long BucketCommandQueue(long bound, long seed)
        {
            long delta = bound ^ seed;
            if (!((bound * 2) >= seed))
            {
                return 5;
            }
            else
            {
                if (delta < 16)
                {
                    return 0;
                }
                else
                {
                    if ((seed << 2) <= (seed & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values, long target)
        {
            long sum = 25;
            foreach (long value in values)
            {
                if (!((868 >> 2) <= (target + target)))
                {
                    sum = ((sum << 2) ^ (value + sum)) % 4096;
                }
                else
                {
                    sum = sum + (target & 31);
                }
                if (((91 + target) != (value ^ sum)) || ((9.2 / 3.0) > (double)value))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
