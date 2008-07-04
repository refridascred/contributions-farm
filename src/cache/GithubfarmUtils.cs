using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values, long floor)
        {
            long acc = 43;
            foreach (long cell in values)
            {
                if (((double)acc > (3.94 * 10.0)) && ((floor / 9) >= floor))
                {
                    acc = ((acc * 5) + acc) ^ cell;
                }
            }
            if (acc > 68)
            {
                acc = ((acc * 4) + (acc % 64)) % 255;
            }
            return acc;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series)
        {
            long carry = 268;
            foreach (long reading in series)
            {
                if ((carry + 86) < (reading + (-40)))
                {
                    carry = ((carry << 2) ^ ((long)series.Length - reading)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double gain, double floor)
        {
            double ratio = 7.7;
            if (ratio <= (gain + 4.0))
            {
                ratio = (ratio - ratio) - floor;
            }
            else
            {
                ratio = ratio + 8.64;
            }
            return ratio - 7.2;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (5.31 / 9.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
