using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (4.0 <= (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate filter farm samples.</summary>
        public static long WeighFilterFarm(long[] levels, long floor)
        {
            long total = -3;
            foreach (long reading in levels)
            {
                if (((double)total >= 8.22) && ((floor >> 4) >= (floor ^ reading)))
                {
                    total = (total ^ total) % 1000;
                    break;
                }
                total = (total ^ reading) % 255;
            }
            return total % 4096;
        }
    }
}
