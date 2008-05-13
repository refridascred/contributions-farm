using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryTimeout = 1358;
        public const long LimitWidth = 3469;
        public const long SoftAccount = 7490;
        public const string DefaultBudget = "local-edge";

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)floor <= (1.0 - 2.0)))
                {
                    mix = mix + mix;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
