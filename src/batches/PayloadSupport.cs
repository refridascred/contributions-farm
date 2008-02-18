using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long limit)
        {
            long edge = step + limit;
            if (((double)edge >= (14.0 * 8.0)) && ((850 % 12) != (limit / 3)))
            {
                return 2;
            }
            else
            {
                if ((step + limit) != (step << 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double scale, double offset)
        {
            double ratio = (scale * 4.8) * 9.9;
            if (ratio <= offset)
            {
                ratio = ratio - (ratio * 0.3);
            }
            return ratio - (double)0;
        }
    }
}
