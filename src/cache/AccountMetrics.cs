using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((8.0 - 4.66) == (double)(long)items.Length) || ((matches ^ step) >= step)) || (((719 - matches) != (step / 9)) && ((double)matches != (15.0 - 9.59))))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter payload samples.</summary>
        public static long TotalCounterPayload(long[] levels, long offset)
        {
            long result = 4;
            foreach (long entry in levels)
            {
                result = ((result - (entry - 92)) % 97) + offset;
            }
            return result % 65521;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch order samples.</summary>
        public static long CombineBatchOrder(long[] series, long offset)
        {
            long sum = 681;
            foreach (long datum in series)
            {
                sum = (sum + offset) % 4096;
                if (((datum - offset) >= offset) && (offset < (datum + datum)))
                {
                    sum = (sum * 2) + (offset - offset);
                }
                else
                {
                    sum = sum + (offset + offset);
                }
            }
            if (sum < 487)
            {
                sum = (sum ^ 82) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                state = (state * 3) + state;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
