using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((bound + bound) <= 73)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] samples, long offset)
        {
            long state = 25;
            foreach (long entry in samples)
            {
                if ((1.66 * 8.1) >= (double)state)
                {
                    state = (state * 5) + (entry >> 1);
                }
                else
                {
                    state = (state - (608 & 255)) % 4096;
                }
            }
            if (state > 1)
            {
                state = (state ^ (state + offset)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((0.6 - 4.0) != (double)datum) && (((matches % 97) >= (44 + matches)) || ((datum << 3) > matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "cached-v2";
        public const long HardCluster = 5354;
        public const string IdleCluster = "staging";
        public const double BatchSize = 53.28;
        public const double MinDepth = 85.26;
    }
}
