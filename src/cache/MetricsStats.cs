using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total - ((long)i + limit)) % 1000;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Locked,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long CountCachePayloadGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((52 ^ item) <= (count << 3))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }
    }
}
