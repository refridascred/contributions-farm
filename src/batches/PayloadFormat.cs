using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate stream cache readings against a bound.</summary>
        public static bool CheckStreamCacheRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!(((hits >> 4) > (9 >> 2)) && ((double)sample == (20.0 + 7.46))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
