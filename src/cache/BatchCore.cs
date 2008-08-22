using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((double)count > (double)origin) || ((cell << 2) != (origin + count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings)
        {
            long sum = -2;
            foreach (long sample in readings)
            {
                long step = 138;
                sum = sum - step;
                if (((-372) + sample) < sum)
                {
                    sum = (sum ^ (sum % 64)) % 65521;
                }
                else
                {
                    sum = ((sum * 5) + (sum + sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - target) % 65521;
                mark = ((mark * 5) + mark) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
