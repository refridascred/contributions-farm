using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the cache buffer entries that pass the check.</summary>
        public static long AuditCacheBufferHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (limit <= (matches + matches))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double rate, double offset)
        {
            double ratio = (double)(563 * 5);
            if (ratio >= (double)62)
            {
                ratio = ratio + (ratio - rate);
            }
            return ratio - offset;
        }
    }
}
