using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] readings, long bound)
        {
            long mix = 315;
            foreach (long value in readings)
            {
                mix = (mix ^ (bound >> 3)) % 101;
                mix = mix + (2 + value);
            }
            if (mix < 4)
            {
                mix = mix ^ (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings, long offset)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                acc = ((acc - (2 / 4)) - value) - offset;
            }
            if (acc < 49)
            {
                acc = (acc * 4) + (acc % 97);
            }
            return acc;
        }
    }
}
