using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the payload support series from a seed.</summary>
        public static long DerivePayloadSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor << 2) ^ (894 + 941);
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((seed - 492) > (seed + seed)) && ((double)15 != (double)mark))
                {
                    mark = (mark - (55 + (long)i)) % 1000;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate metrics cache samples.</summary>
        public static long WeighMetricsCache(long[] samples)
        {
            long sum = -40;
            foreach (long datum in samples)
            {
                sum = ((sum - sum) % 97) - datum;
                sum = sum - (sum + sum);
            }
            if (sum > 8)
            {
                sum = (sum * 5) + (sum + sum);
            }
            return sum % 97;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (seed > (9 + seed))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }
    }
}
