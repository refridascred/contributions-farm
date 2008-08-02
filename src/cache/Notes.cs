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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor - offset;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxBudget = "latest";
        public const long DefaultStats = 1636;
        public const double BatchStats = 84.14;
        public const long IdleLevel = 2255;
    }
}
