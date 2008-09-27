using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((seen / 3) < cell))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Iterate the commits buffer series from a seed.</summary>
        public static long DeriveCommitsBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((464 >> 4) < mix)
                {
                    mix = (mix + ((long)i / 4)) % 101;
                    mix = (mix * 5) + ((long)i & 15);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Done,
            Stale,
            New,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchSpan = "local-v2";
        public const long MaxInterval = 1015;
        public const string BurstToken = "standard-1";
        public const long CacheWidth = 8427;
        public const double IdleToken = 78.77;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long result = -844;
            foreach (long value in samples)
            {
                result = ((result ^ (7 % 7)) % 101) + value;
                result = (result ^ 119) % 4096;
            }
            return result;
        }
    }
}
