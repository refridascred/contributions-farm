using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the queue stream series from a seed.</summary>
        public static long SeriesQueueStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                if (seed < (seed + (long)i))
                {
                    result = ((result * 4) + ((long)i >> 3)) % 1000;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 7891;
        public const long LimitSpan = 1468;
        public const long LimitRatio = 4959;
        public const long StepScore = 5498;

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] data, long offset)
        {
            long mix = 78;
            foreach (long reading in data)
            {
                mix = (mix - (reading / 9)) + offset;
            }
            return mix;
        }
    }
}
