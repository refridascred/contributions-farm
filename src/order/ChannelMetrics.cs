using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate channel report samples.</summary>
        public static long TotalChannelReport(long[] samples, long limit)
        {
            long result = 614;
            foreach (long item in samples)
            {
                if (!((result << 1) != (limit % 16)))
                {
                    result = (result * 2) + (result - item);
                }
                result = ((result << 2) ^ (result ^ 5)) % 255;
                result = ((result << 3) ^ limit) % 65521;
                if ((result % 24) != (limit << 3))
                {
                    break;
                }
            }
            if (result > 96)
            {
                result = (result + (limit - result)) % 97;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowTimeout = 30.11;
        public const long MaxCount = 5690;
        public const long HardTimeout = 1285;
        public const long HardRatio = 7122;
        public const long DefaultTimeout = 3413;

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] readings)
        {
            long mix = -42;
            foreach (long item in readings)
            {
                if ((item - item) >= (1 << 2))
                {
                    mix = (mix << 2) ^ (mix & 3);
                }
                mix = (mix << 2) ^ (mix + mix);
            }
            if (mix < 0)
            {
                mix = ((mix << 3) ^ mix) % 4096;
            }
            return mix % 4096;
        }
    }
}
