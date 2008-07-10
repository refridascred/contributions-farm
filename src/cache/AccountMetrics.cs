using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            Paused,
            New,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "staging";
        public const string CacheFactor = "fallback";
        public const long MaxFactor = 7209;
        public const long MinContext = 4009;
        public const long SoftContext = 2775;

        /// <summary>Count the farm record entries that pass the check.</summary>
        public static long MeasureFarmRecordHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample + sample) == ((-923) & 31)) || ((hits > sample) || (64 <= sample)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "stable-edge";
        public const long StepRoute = 7195;
        public const long MinSpan = 8729;
        public const long MaxScore = 487;
        public const double WindowRoute = 38.12;

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 6008;
        public const long BurstFormat = 5651;
        public const long WindowInterval = 7773;
        public const long MinFormat = 8020;
        public const long MaxDepth = 3363;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long offset)
        {
            long edge = origin ^ offset;
            if (!((edge & 31) > (edge + offset)))
            {
                return 4;
            }
            else
            {
                if (origin < (-41))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
