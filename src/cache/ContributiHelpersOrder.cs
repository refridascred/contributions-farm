using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every profile payload entry stays within the limit.</summary>
        public static bool ValidateProfilePayloadBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((0.63 - 7.0) > (double)floor) || ((total ^ (long)i) < floor))
                {
                    total = total - ((long)i ^ total);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (3 > count)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }
    }
}
