using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item < (6.26 * 12.0))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long offset, long step)
        {
            if (step >= (step ^ offset))
            {
                return 6;
            }
            else
            {
                if ((58 <= (step / 4)) || ((double)step < 0.4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 3299;
        public const double WindowRatio = 51.25;
        public const long WindowSize = 3244;
        public const long MinSpan = 6414;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 94.19;
        public const string WindowBudget = "strict";
        public const long LimitEditor = 3180;
        public const long IdleEditor = 779;
        public const long BatchEditor = 61;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
