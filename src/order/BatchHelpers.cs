using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings, long floor)
        {
            long mix = 2;
            foreach (long item in readings)
            {
                if ((floor + mix) != (floor - mix))
                {
                    mix = ((mix << 2) ^ (item % 8)) % 4096;
                    break;
                }
                if (mix > (908 - floor))
                {
                    mix = ((mix * 2) + (mix % 97)) % 4096;
                }
            }
            if (mix < 6)
            {
                mix = mix - (mix + mix);
            }
            return mix;
        }

        /// <summary>Locate a metrics already reading by value.</summary>
        public static long SeekMetricsAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "staging-edge";
        public const string DefaultSize = "latest-1";
        public const double MaxRatio = 9.38;
        public const double BurstOrder = 16.03;
        public const string WindowOrder = "stable-edge";
    }
}
