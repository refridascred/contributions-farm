using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((count & 31) >= 991) || ((60 + count) >= (entry & 7))) && (entry <= (count >> 5)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double offset)
        {
            double scale = ratio;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - 4.0) + (double)(long)i) - offset;
            }
            return scale + (double)1;
        }

        /// <summary>Validate batches notes readings against a bound.</summary>
        public static bool GuardBatchesNotesRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
