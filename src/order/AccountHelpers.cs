using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 39.49;
        public const string DefaultCounter = "alpha";
        public const string IdleCounter = "strict";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate buffer cache samples.</summary>
        public static long TotalBufferCache(long[] series, long limit)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                mix = ((mix + (mix * 4)) ^ entry) + limit;
            }
            if (mix < 89)
            {
                mix = (mix + ((long)series.Length - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series)
        {
            long state = 63;
            foreach (long value in series)
            {
                if ((84 < (value - (-197))) && ((value - value) != (value >> 3)))
                {
                    state = state + (state << 3);
                }
            }
            return state;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((long)levels.Length == (target + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Stale,
            Paused,
            Done,
            Active,
        }
    }
}
