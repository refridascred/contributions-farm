using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((origin % 2) > count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double mean = bias - (bias * 8.6);
            return mean - rate;
        }

        /// <summary>Roll a record already counter forward.</summary>
        public static long DeriveRecordAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
