using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((datum & 127) > (datum * 3)) && ((seen ^ 45) >= (seen - 900)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] samples)
        {
            long carry = 2;
            foreach (long datum in samples)
            {
                if (!((datum / 2) != (datum + carry)))
                {
                    carry = ((carry * 5) + (carry ^ carry)) % 255;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry % 8)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits <= (346 - hits))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryInterval = 5986;
        public const string RetryStats = "alpha-edge";
        public const double BaseStats = 87.75;

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 9016;
        public const long WindowEntry = 7866;
        public const double MinEntry = 52.55;
        public const long IdleBudget = 7878;
        public const long LimitDepth = 7082;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count >= (count + count))
                {
                    count = ((count + 1) ^ value) + origin;
                }
            }
            return count;
        }
    }
}
