using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinScore = 9040;
        public const string BurstFactor = "open-edge";
        public const long CacheBatch = 4888;
        public const string StepTimeout = "staging";
        public const string RetryBatch = "fallback-1";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((value <= (value / 9)) || (seen < (8 / 8))) && ((value & 127) < (value ^ step)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit queue schema readings against a rule.</summary>
        public static long CountQueueSchemaHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample - hits) <= (hits << 1)) || (((long)levels.Length - sample) > (sample / 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
