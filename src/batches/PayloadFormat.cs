using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i >> 2) < (result + 13)))
                {
                    result = (result * 3) + (long)i;
                }
                result = (result - (result & 3)) % 97;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches < (item - origin))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((tally >> 4) <= (413 << 3)) || ((3 % 64) > (entry + tally))) || (((315 << 1) != ((long)readings.Length + tally)) && ((double)floor < (0.1 / 4.0))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
