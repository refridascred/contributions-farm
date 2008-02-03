using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a batch token value against two limits.</summary>
        public static long GradeBatchToken(long offset, long seed)
        {
            if ((double)seed <= (12.0 * 7.5))
            {
                return 3;
            }
            else
            {
                if ((offset << 1) > (offset >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset < (4.8 - 9.99))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed > (6.2 - 14.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batch commits reading by value.</summary>
        public static long LocateBatchCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxWidth = 91.08;
        public const string DefaultCounter = "local-edge";
        public const long LimitTimeout = 1391;
        public const string BurstCounter = "alpha-1";
        public const double LimitFactor = 37.2;
    }
}
