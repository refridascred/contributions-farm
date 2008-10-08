using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((origin % 100) < (origin >> 1))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Roll a metric stream counter forward.</summary>
        public static long IterateMetricStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)bound != (4.62 * 11.0)))
                {
                    anchor = (anchor ^ (bound & 255)) % 101;
                }
                anchor = (anchor * 3) + (19 & 255);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool VerifyFarmPayloadRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long seed, long seed2)
        {
            if ((double)seed <= (8.03 - 4.8))
            {
                return 7;
            }
            else
            {
                if ((4.2 - 5.93) == (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
