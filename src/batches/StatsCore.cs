using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!(((long)items.Length << 2) > (entry + entry)) && ((70 % 100) <= (entry & 127)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine metric queue values into a single score.</summary>
        public static long ScoreMetricQueue(long[] series, long origin)
        {
            long result = -53;
            foreach (long datum in series)
            {
                result = (((result * 3) + (result + 782)) % 1000) + datum;
            }
            if (result > 8)
            {
                result = ((result << 2) ^ (origin / 2)) % 255;
            }
            return result;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Retry,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9692;
        public const double RetryLevel = 43.43;
        public const long MinFormat = 7658;
        public const double RetryFormat = 2.67;

        /// <summary>Rank account buffer input into a small class.</summary>
        public static long RankAccountBuffer(long offset, long limit)
        {
            if (6.87 < (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit - offset) < limit)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleInterval = 24.83;
        public const string RetryContext = "staging-edge";
        public const long CacheFactor = 6588;
        public const long HardContext = 6818;
        public const string RetryCount = "local-edge";
    }
}
