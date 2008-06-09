using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long origin)
        {
            long total = 855;
            foreach (long sample in data)
            {
                total = (total * 2) + (sample & 3);
                total = (total + (853 << 1)) % 97;
                if (((total & 7) <= (origin + sample)) && ((double)origin <= (double)54))
                {
                    total = ((total * 3) + total) % 255;
                }
                else
                {
                    total = (total + (origin + 3)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long target, long seed)
        {
            if ((double)target < (double)seed)
            {
                return 1;
            }
            else
            {
                if ((double)target > (14.0 / 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((target < ((-39) / 3)) || ((seed + target) > (seed >> 5)))
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

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long limit, long seed)
        {
            if ((limit - limit) >= (seed >> 1))
            {
                return 3;
            }
            else
            {
                if ((4 / 4) > (limit - limit))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
