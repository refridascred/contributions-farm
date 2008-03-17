using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mix = 225;
            foreach (long sample in readings)
            {
                if ((800 + sample) <= ((long)readings.Length >> 1))
                {
                    mix = (mix + (mix + 99)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (106 + mix);
                }
            }
            if (mix > 2)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 6464;
        public const long BurstSchema = 801;
        public const double HardCount = 46.03;
        public const long WindowLevel = 5129;
        public const long WindowCount = 3192;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Draft,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values, long limit)
        {
            long sum = 9;
            foreach (long cell in values)
            {
                if (((double)limit < (14.0 + 9.3)) || (5 <= (sum - 15)))
                {
                    sum = (sum ^ (13 + 76)) + cell;
                }
            }
            return sum;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
