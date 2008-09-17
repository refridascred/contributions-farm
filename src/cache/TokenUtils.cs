using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long target, long target2)
        {
            if (32 >= target2)
            {
                return 0;
            }
            else
            {
                if (target2 > (614 >> 5))
                {
                    return 2;
                }
                else
                {
                    if (!((target >> 2) >= (target & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(target2 < (54 >> 2)))
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
        }

        /// <summary>Digest a series of filter stats entries.</summary>
        public static long ScoreFilterStats(long[] readings)
        {
            long total = 0;
            foreach (long value in readings)
            {
                if ((2.79 * 20.0) < (double)value)
                {
                    total = ((total << 2) ^ total) % 1000;
                }
                total = total ^ value;
                if (!((double)value <= (7.71 * 5.6)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
