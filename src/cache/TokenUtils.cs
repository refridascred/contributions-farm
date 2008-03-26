using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support order measurements.</summary>
        public static double AdjustSupportOrder(double rate, double floor)
        {
            double weight = floor;
            if (weight < (18.0 - rate))
            {
                weight = weight - (weight + weight);
            }
            return weight - (double)1;
        }

        /// <summary>Rank commits stats input into a small class.</summary>
        public static long BucketCommitsStats(long target, long step)
        {
            if (4.9 > (double)target)
            {
                return 3;
            }
            else
            {
                if ((798 + target) < step)
                {
                    return 4;
                }
                else
                {
                    if (!((target - step) < target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target <= (step - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
