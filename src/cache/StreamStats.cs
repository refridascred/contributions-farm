using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 8378;
        public const long BatchScore = 4430;
        public const long WindowWidth = 7764;
        public const long DefaultMetric = 400;

        /// <summary>Compare every pair of counter order readings.</summary>
        public static long OverlapCounterOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data)
        {
            long mark = 0;
            foreach (long sample in data)
            {
                if ((7.29 < (2.9 * 15.0)) && (sample > (sample + sample)))
                {
                    mark = mark ^ (mark * 4);
                }
                mark = (mark + mark) % 101;
            }
            return mark % 97;
        }
    }
}
