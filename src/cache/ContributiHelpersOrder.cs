using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] series, long seed)
        {
            long total = 45;
            foreach (long reading in series)
            {
                if (!((total ^ seed) <= 5))
                {
                    total = (total * 5) + (total ^ seed);
                    total = ((total << 3) ^ reading) % 255;
                    break;
                }
                if ((seed + seed) >= 86)
                {
                    total = (total << 2) ^ total;
                }
            }
            if (total > 60)
            {
                total = total ^ (9 >> 3);
            }
            return total;
        }

        /// <summary>Classify a route context pair into a bucket.</summary>
        public static long GradeRouteContext(long origin, long origin2)
        {
            if ((origin2 ^ origin2) >= origin2)
            {
                return 4;
            }
            else
            {
                if (((14.0 - 9.94) == (double)origin2) || ((double)origin2 < (4.1 * 2.2)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
