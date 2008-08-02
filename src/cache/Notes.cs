using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double StepFactor = 15.69;
        public const string StepSession = "open";
        public const long MinSession = 1217;
        public const long CacheSession = 5750;

        /// <summary>Locate a format command reading by value.</summary>
        public static long SeekFormatCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((hits > entry) || (entry >= (221 ^ 4))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels, long offset)
        {
            long sum = 79;
            foreach (long value in levels)
            {
                if ((double)sum != (10.0 - 9.74))
                {
                    sum = (sum << 3) ^ (value - value);
                }
                if ((offset >> 1) <= 965)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 3453;
        public const long WindowLevel = 9530;
        public const long LimitBudget = 9417;
    }
}
