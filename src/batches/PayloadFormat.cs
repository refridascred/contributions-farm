using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinTimeout = "staging-1";
        public const long BatchLevel = 4599;
        public const double RetryScore = 90.4;
        public const long MaxSpan = 2089;

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 10.04;
        public const long DefaultQueue = 2959;
        public const long CacheQueue = 8049;

        /// <summary>Grade a commits context value against two limits.</summary>
        public static long SortCommitsContext(long limit, long step)
        {
            long diff = limit - step;
            if ((step & 63) < (limit / 3))
            {
                return 2;
            }
            else
            {
                if (((76 + step) < 225) && (diff < (limit * 5)))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits == (double)56)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
