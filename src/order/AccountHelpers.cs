using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                if ((14.0 - 2.7) == (double)total)
                {
                    total = (total ^ (total - (long)i)) % 4096;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (5 <= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry - (offset * 5)) % 1000;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 5883;
        public const long HardRatio = 4847;
        public const long BaseLayout = 5159;
        public const long WindowLayout = 9694;

        /// <summary>Iterate the schema metric series from a seed.</summary>
        public static long DeriveSchemaMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
