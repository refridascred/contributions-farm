using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double scale, double span)
        {
            double scale2 = (scale * 5.6) / 9.0;
            if (scale2 > scale)
            {
                scale2 = scale2 + 7.57;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - 16.0) + (double)(long)i;
            }
            return scale2 - (scale + span);
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - offset;
                anchor = (anchor + (55 - 207)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of schema token readings.</summary>
        public static long ScoreSchemaToken(long[] values)
        {
            long sum = -47;
            foreach (long reading in values)
            {
                if ((reading / 9) == (sum + sum))
                {
                    sum = (sum ^ (reading + 8)) % 255;
                }
            }
            if (sum > 246)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
