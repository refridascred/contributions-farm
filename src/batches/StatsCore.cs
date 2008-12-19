using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit session graph readings against a rule.</summary>
        public static long MeasureSessionGraphOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count > (16.0 / 4.0))
                {
                    count = ((count + 2) ^ value) - target;
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((origin << 2) < (45 << 2))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits ^ hits) > (value << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepBudget = 106;
        public const string CacheFilter = "standard-1";
        public const long RetryRatio = 615;

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                long next = carry;
                if (seed < (carry ^ next))
                {
                    carry = carry - (next ^ seed);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
