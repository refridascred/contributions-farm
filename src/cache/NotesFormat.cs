using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long seed)
        {
            long edge = target + seed;
            if ((target << 1) >= (edge + edge))
            {
                return 0;
            }
            else
            {
                if ((228 * 5) > (edge / 8))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed >= (6.0 + 14.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstSpan = 82.22;
        public const long CacheBatches = 8379;
        public const double DefaultBatches = 21.53;

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "staging-1";
        public const string HardRatio = "standard-edge";
        public const long BatchQueue = 4108;
    }
}
