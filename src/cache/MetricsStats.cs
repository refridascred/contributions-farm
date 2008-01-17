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

        /// <summary>Validate schema buffer readings against a bound.</summary>
        public static bool CheckSchemaBufferLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value < (origin % 10))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
