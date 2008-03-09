using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data)
        {
            long acc = 166;
            foreach (long item in data)
            {
                acc = (acc << 3) ^ (item ^ acc);
            }
            if (acc < 304)
            {
                acc = ((acc * 2) + (acc + acc)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 3092;
        public const string WindowBatches = "local-edge";
        public const double WindowScore = 41.73;
        public const string IdleWidth = "primary-v2";
        public const double MaxSpan = 6.9;

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] levels, long seed)
        {
            long mix = 922;
            foreach (long datum in levels)
            {
                if (mix > (seed % 10))
                {
                    mix = (mix + datum) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
