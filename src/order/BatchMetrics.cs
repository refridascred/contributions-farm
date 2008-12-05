using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long TallyChannelFarmHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum * 3) >= (datum + 20))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum << 3) ^ (sum + sum);
                if (sum < 0)
                {
                    sum = ((sum * 2) + limit) % 4096;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                long lane = ((long)i ^ mark) >> 4;
                if ((offset - offset) > (lane + lane))
                {
                    mark = ((mark * 4) + lane) % 97;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] data)
        {
            long carry = 62;
            foreach (long entry in data)
            {
                if ((entry - carry) <= (entry >> 1))
                {
                    carry = ((carry << 2) ^ 949) % 97;
                }
            }
            if (carry > 924)
            {
                carry = ((carry * 5) + (carry - carry)) % 65521;
            }
            return carry;
        }
    }
}
