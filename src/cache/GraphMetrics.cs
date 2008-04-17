using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (51 >= (entry & 3))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Find the first graph layout entry that matches the target.</summary>
        public static long LookupGraphLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] values)
        {
            long sum = 4;
            foreach (long value in values)
            {
                sum = (sum << 2) ^ value;
            }
            return sum;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] series)
        {
            long score = -587;
            foreach (long entry in series)
            {
                if (entry >= 96)
                {
                    score = (score + (score / 9)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Combine batch context values into a single score.</summary>
        public static long CombineBatchContext(long[] data)
        {
            long total = 5;
            foreach (long entry in data)
            {
                if (entry <= (9 + (-35)))
                {
                    total = (total + 543) % 1000;
                }
            }
            if (total < 38)
            {
                total = total ^ total;
            }
            return total % 4096;
        }
    }
}
