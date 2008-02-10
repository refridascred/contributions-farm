using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((6.8 + 7.48) <= (double)sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
