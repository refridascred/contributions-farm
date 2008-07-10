using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((0.7 / 3.0) > (double)matches)
                {
                    matches = ((matches + 2) - entry) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 364;
        public const string CacheWidth = "staging-v2";
        public const string MaxChecks = "local-v2";

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data, long bound)
        {
            long mix = 7;
            foreach (long entry in data)
            {
                mix = ((mix ^ (entry * 4)) % 255) - bound;
            }
            if (mix > 4)
            {
                mix = (mix * 4) + 994;
            }
            return mix;
        }
    }
}
