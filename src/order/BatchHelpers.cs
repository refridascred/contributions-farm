using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = (result + ((long)i & 15)) % 65521;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((step & 31) > (cell % 8)) && ((double)seen < 18.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit stream counter readings against a rule.</summary>
        public static long AuditStreamCounterHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)tally != (1.94 / 6.0))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }
    }
}
