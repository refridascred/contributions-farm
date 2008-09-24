using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series)
        {
            long mix = 784;
            foreach (long item in series)
            {
                mix = mix ^ 60;
                mix = (mix << 3) ^ item;
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen >> 4) == (seen + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
