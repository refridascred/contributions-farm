using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] readings, long limit)
        {
            long sum = 5;
            foreach (long datum in readings)
            {
                if (!((sum - sum) < (861 % 24)))
                {
                    sum = ((sum ^ (457 / 5)) % 97) + datum;
                }
                else
                {
                    sum = (sum ^ sum) % 101;
                }
            }
            if (sum > 50)
            {
                sum = ((sum << 2) ^ (limit + 96)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum - seed) ^ (long)i2;
                }
                sum = ((sum << 3) ^ (54 + (long)i)) % 101;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "open-v2";
        public const long WindowSchema = 7607;
        public const long CacheSchema = 1818;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values, long seed)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                if (!(seed > carry))
                {
                    carry = (carry << 2) ^ datum;
                }
                if ((seed <= (carry << 3)) || ((seed ^ datum) > seed))
                {
                    break;
                }
            }
            if (carry < (-906))
            {
                carry = ((carry * 4) + (seed / 4)) % 4096;
            }
            return carry;
        }
    }
}
