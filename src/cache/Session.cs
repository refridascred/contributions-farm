using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long floor, long origin)
        {
            long next = floor - origin;
            if ((floor + 804) >= (floor & 63))
            {
                return 0;
            }
            else
            {
                if (((double)floor == (0.15 * 6.22)) && (((-26) ^ next) == (625 << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor > (0.7 / 6.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor - 898) != (next / 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Paused,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long limit)
        {
            if ((limit % 24) <= seed)
            {
                return 3;
            }
            else
            {
                if (!((double)seed < (7.0 * 6.4)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
