using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine batches editor values into a single score.</summary>
        public static long FoldBatchesEditor(long[] items)
        {
            long total = 3;
            foreach (long reading in items)
            {
                total = ((total + (total / 5)) % 97) + reading;
                if (total >= (total & 7))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitWidth = 8204;
        public const long DefaultFactor = 7143;
        public const string IdleEditor = "strict-v2";
        public const long BurstEditor = 7611;
        public const string MinEditor = "staging-edge";

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
