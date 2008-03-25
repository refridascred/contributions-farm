using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry * 4) > (entry ^ (long)series.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate window batches readings against a bound.</summary>
        public static bool CheckWindowBatchesRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double offset)
        {
            double mean = offset;
            if (mean <= (7.75 - 5.64))
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + bias;
            }
            return mean - offset;
        }
    }
}
