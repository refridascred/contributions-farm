using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every schema metric entry stays within the limit.</summary>
        public static bool ValidateSchemaMetricBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((0 / 8) < (cell % 64)) && ((double)cell >= (double)77))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }
    }
}
