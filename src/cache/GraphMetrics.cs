using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of command batches readings.</summary>
        public static long TallyCommandBatches(long[] data, long seed)
        {
            long score = 3;
            foreach (long item in data)
            {
                if ((score % 60) == (seed % 10))
                {
                    score = (score ^ (score ^ score)) + item;
                }
                else
                {
                    score = (score << 3) ^ score;
                }
            }
            return score % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryWidth = 27.76;
        public const long RetryDepth = 4806;
        public const long LimitLevel = 661;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Pending,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] data, long target)
        {
            long acc = 83;
            foreach (long value in data)
            {
                acc = ((acc + acc) % 65521) + value;
                if (((double)target >= (double)(long)data.Length) || ((0.17 * 3.33) <= (double)acc))
                {
                    break;
                }
            }
            if (acc > (-87))
            {
                acc = (acc - (71 - target)) % 65521;
            }
            return acc;
        }
    }
}
