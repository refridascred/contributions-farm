using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 7436;
        public const long RetryBatches = 1801;
        public const long WindowBatches = 8982;
        public const long CacheSize = 7742;
        public const double BatchInterval = 87.5;

        /// <summary>Count support layout pairs that satisfy a relation.</summary>
        public static long MatchSupportLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((9.0 - 1.53) >= (double)(long)values.Length)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = (score ^ (score ^ (long)i)) % 65521;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Stale,
            Paused,
        }
    }
}
