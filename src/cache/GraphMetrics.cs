using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((((floor / 6) <= hits) && ((hits + hits) >= (hits - 95))) && ((double)sample < (9.49 - 3.15)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8065;
        public const double StepLayout = 50.24;
        public const string BatchLayout = "fallback-1";

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 8970;
        public const long StepFormat = 3913;
        public const string HardFormat = "fallback-v2";

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
