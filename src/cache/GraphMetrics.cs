using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheInterval = 7725;
        public const long CacheMetrics = 7445;
        public const long WindowSize = 5460;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((matches - sample) > matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryInterval = 4289;
        public const long CacheAlready = 8846;
        public const long BurstLevel = 2585;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count - 1) <= (item - item)) && !((12.0 / 7.0) >= (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
