using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Stale,
            Queued,
            Done,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long seed)
        {
            long next = floor + seed;
            if ((double)seed > (4.7 - 8.1))
            {
                return 0;
            }
            else
            {
                if ((next - next) >= (next * 2))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((37 << 2) >= (seed >> 3))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }
    }
}
