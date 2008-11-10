using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many context graph samples are out of range.</summary>
        public static long MeasureContextGraphOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length + datum) != (matches + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)bound != (9.0 * 9.1))
                {
                    carry = carry + (long)i;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
