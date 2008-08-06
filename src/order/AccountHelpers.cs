using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > 77)
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Adjust a stats farm reading.</summary>
        public static double ProjectStatsFarm(double bias, double floor)
        {
            double scale = 5.0;
            if (scale >= (7.19 * 1.93))
            {
                scale = (scale + (double)61) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale - (scale / 7.0);
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = (anchor ^ item) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] data)
        {
            long score = 4;
            foreach (long entry in data)
            {
                if ((score / 8) <= (score * 4))
                {
                    score = (score - entry) % 101;
                }
            }
            return score;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((tally / 6) != (tally & 1)) && ((tally + tally) <= (value >> 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 >= (gain / 9.0))
            {
                gain2 = (gain2 + 10.0) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = gain2 + (double)(long)i;
            }
            return gain2 - (double)(-501);
        }
    }
}
