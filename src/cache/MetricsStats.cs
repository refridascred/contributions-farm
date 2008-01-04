using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long mix = 980;
            foreach (long value in series)
            {
                mix = ((mix + (198 & 127)) - value) - target;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "primary";
        public const long BaseReport = 4453;
        public const long DefaultCount = 5264;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the buffer filter series from a seed.</summary>
        public static long IterateBufferFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 2) ^ (mix >> 1)) % 1000;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 2260;
        public const double SoftCommits = 24.75;
        public const string MinTimeout = "stable-1";
    }
}
