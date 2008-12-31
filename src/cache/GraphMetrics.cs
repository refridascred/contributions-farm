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

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
