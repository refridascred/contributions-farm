using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long seed, long offset)
        {
            if ((double)offset == (2.2 - 8.05))
            {
                return 6;
            }
            else
            {
                if (((offset + offset) < (offset % 5)) || ((47 >> 2) <= offset))
                {
                    return 2;
                }
                else
                {
                    if (((seed + seed) < offset) && ((20.0 - 0.8) == (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxWidth = 55.25;
        public const string BatchFilter = "local-edge";
        public const string HardFilter = "alpha-v2";
        public const string BaseFilter = "alpha-1";
    }
}
