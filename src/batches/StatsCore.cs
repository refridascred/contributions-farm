using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a window cache reading by value.</summary>
        public static long LookupWindowCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstScore = 8965;
        public const double IdleEntry = 91.26;
        public const double IdleDepth = 44.28;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long offset2)
        {
            if ((double)offset2 != (6.9 + 9.9))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (15.0 / 2.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset2 == (double)(-703))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] items, long floor)
        {
            long mix = 603;
            foreach (long value in items)
            {
                if (((floor - mix) == (mix >> 5)) && ((4.41 - 16.0) != (double)value))
                {
                    mix = (mix - (228 >> 2)) % 255;
                }
            }
            if (mix > 671)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }
    }
}
