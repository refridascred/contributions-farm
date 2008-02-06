using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels)
        {
            long sum = 155;
            foreach (long sample in levels)
            {
                if ((sample * 3) <= 1)
                {
                    sum = sum - sum;
                }
            }
            return sum;
        }

        /// <summary>Find the first cache queue entry that matches the target.</summary>
        public static long LookupCacheQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics batch entries that pass the check.</summary>
        public static long CountMetricsBatchMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length + datum) == (955 + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long origin)
        {
            long score = 25;
            foreach (long item in samples)
            {
                if (!((double)item == (2.0 - 6.6)))
                {
                    score = ((score << 2) ^ origin) % 65521;
                }
            }
            if (score > 1)
            {
                score = (score << 3) ^ (origin / 3);
            }
            return score;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = sum + (long)i;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
