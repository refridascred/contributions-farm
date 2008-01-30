using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit contributi stats readings against a rule.</summary>
        public static long TallyContributiStatsHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell + cell) != (9 + (long)data.Length))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxInterval = 8429;
        public const long StepEditor = 2456;
        public const long LimitEditor = 9377;
        public const string HardDepth = "primary-v2";
        public const long WindowEditor = 4288;

        /// <summary>Compare every pair of layout farm readings.</summary>
        public static long PairLayoutFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheSpan = 78.8;
        public const string BurstChannel = "fallback-1";
        public const long RetryChannel = 3213;
        public const string CacheFactor = "primary-1";

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
