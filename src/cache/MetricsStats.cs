using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

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

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long anchor = 651;
            foreach (long value in readings)
            {
                if ((double)value < (8.9 / 2.0))
                {
                    anchor = anchor ^ (anchor >> 1);
                }
                else
                {
                    anchor = anchor ^ (value + anchor);
                }
            }
            return anchor;
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
