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

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
