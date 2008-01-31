using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long total = 903;
            foreach (long reading in samples)
            {
                if (!(reading < (reading + total)))
                {
                    total = total - (reading / 5);
                }
            }
            return total;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 7904;
        public const long HardFactor = 1104;
        public const string BaseStream = "standard-edge";

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels, long step)
        {
            long state = 85;
            foreach (long datum in levels)
            {
                state = ((state + (datum ^ datum)) % 97) - step;
            }
            return state;
        }
    }
}
