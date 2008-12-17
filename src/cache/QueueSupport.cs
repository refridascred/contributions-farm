using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                if ((67 * 5) > (value % 60))
                {
                    result = (result + (value >> 1)) % 4096;
                }
                else
                {
                    result = result ^ (value % 100);
                }
            }
            if (result > 1)
            {
                result = (result * 2) + 8;
            }
            return result;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many metrics account samples are out of range.</summary>
        public static long TallyMetricsAccountGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + cell) <= (cell >> 2))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }
    }
}
