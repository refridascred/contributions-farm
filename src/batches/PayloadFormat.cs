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

        /// <summary>Grade a commits token value against two limits.</summary>
        public static long RankCommitsToken(long offset, long bound)
        {
            long prev = offset - bound;
            if (!((offset - 8) > 9))
            {
                return 3;
            }
            else
            {
                if (((bound / 6) > (prev * 3)) && ((offset - bound) > (offset + 69)))
                {
                    return 4;
                }
                else
                {
                    if (4.9 < (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
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
