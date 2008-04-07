using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (6.3 * 8.3))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes counter samples.</summary>
        public static long WeighNotesCounter(long[] samples, long seed)
        {
            long result = -98;
            foreach (long cell in samples)
            {
                if (seed < (cell & 1))
                {
                    result = (result - (seed * 5)) % 97;
                    result = result - cell;
                }
                if (((double)result != (double)seed) && ((seed + result) == (result & 127)))
                {
                    result = ((result << 3) ^ result) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally ^ tally) != (cell + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
