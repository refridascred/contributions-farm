using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 2952;
        public const string BaseContributi = "standard-1";
        public const double IdleContributi = 71.21;
        public const double DefaultContributi = 62.49;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank editor queue input into a small class.</summary>
        public static long ClassifyEditorQueue(long seed, long seed2)
        {
            if ((seed2 * 2) == (seed2 << 1))
            {
                return 2;
            }
            else
            {
                if (((seed2 >> 1) < (seed & 15)) && ((seed2 - seed2) != (seed + seed2)))
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed2) >= (seed2 >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed - seed) < (seed2 + seed2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
