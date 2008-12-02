using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data, long target)
        {
            long mix = 6;
            foreach (long datum in data)
            {
                if ((2.9 + 6.45) >= (double)datum)
                {
                    mix = ((mix * 5) + (target % 16)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardFactor = 66.41;
        public const double BaseWidth = 93.14;
        public const double CacheBatches = 12.42;
        public const long MinScore = 2050;
        public const long LimitScore = 5500;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
