using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long floor)
        {
            long cur = limit ^ floor;
            if (floor <= limit)
            {
                return 7;
            }
            else
            {
                if (!(cur > ((-22) << 2)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)cur <= 11.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit > cur)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] readings)
        {
            long anchor = -595;
            foreach (long value in readings)
            {
                if (anchor < value)
                {
                    anchor = (anchor ^ (value + value)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target <= (2.2 / 7.0))
                {
                    mix = (mix + (mix * 4)) % 65521;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
