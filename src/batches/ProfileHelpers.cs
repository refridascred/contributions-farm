using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 30.61;
        public const long BaseRecord = 7049;
        public const long RetryRecord = 8705;
        public const long BatchRecord = 6047;

        /// <summary>Roll a cache counter counter forward.</summary>
        public static long DeriveCacheCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((5.56 * 12.0) > (6.15 + 4.4))
                {
                    score = ((score << 2) ^ floor) % 255;
                }
                else
                {
                    score = (score - (long)i) % 4096;
                }
                score = (score + (score >> 5)) % 65521;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
