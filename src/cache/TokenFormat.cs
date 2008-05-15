using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long origin)
        {
            long edge = step + origin;
            if (((6.7 - 8.9) > (double)origin) && (origin > (edge + step)))
            {
                return 8;
            }
            else
            {
                if ((step + origin) == (step >> 4))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long offset, long seed)
        {
            if (!((0.6 / 9.0) != (double)seed))
            {
                return 5;
            }
            else
            {
                if ((offset % 12) < (seed / 6))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
