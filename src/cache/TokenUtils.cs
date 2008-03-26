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

        /// <summary>Rank farm report input into a small class.</summary>
        public static long BucketFarmReport(long step, long origin)
        {
            long next = step + origin;
            if ((origin % 2) != (next >> 5))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) > step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (ratio * 7.28)) - (double)(long)i) + span;
            }
            return load - (ratio / 8.0);
        }
    }
}
