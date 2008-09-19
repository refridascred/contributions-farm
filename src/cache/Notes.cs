using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long seed, long floor)
        {
            long lane = seed ^ floor;
            if (((lane << 2) > (floor ^ floor)) && (lane >= (seed * 2)))
            {
                return 2;
            }
            else
            {
                if ((seed - 840) > (lane & 127))
                {
                    return 8;
                }
                else
                {
                    if ((double)lane <= (0.65 / 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - seed) != (920 % 16))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 26;
        public const long MaxSize = 1607;
        public const long WindowLevel = 3317;
        public const double LimitWidth = 89.94;
        public const string MaxScore = "primary-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 11.11;
        public const string CacheCount = "alpha-1";
        public const long DefaultStats = 161;
        public const long IdleCount = 4513;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] series)
        {
            long anchor = 5;
            foreach (long cell in series)
            {
                if ((double)cell <= 6.23)
                {
                    anchor = (anchor + 4) % 255;
                }
            }
            if (anchor > (-53))
            {
                anchor = anchor + (anchor >> 5);
            }
            return anchor % 4096;
        }
    }
}
