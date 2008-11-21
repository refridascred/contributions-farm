using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((2.5 + 0.55) <= (double)step)
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > (double)8)
            {
                scale2 = scale2 + 4.4;
            }
            else
            {
                scale2 = scale2 - offset;
            }
            return scale2 - scale2;
        }
    }
}
