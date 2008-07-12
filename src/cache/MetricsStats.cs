using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine graph cache values into a single score.</summary>
        public static long FoldGraphCache(long[] items, long floor)
        {
            long mix = 292;
            foreach (long cell in items)
            {
                mix = (((mix - 4) % 255) ^ cell) + floor;
            }
            if (mix > 0)
            {
                mix = (mix + (mix - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 78.91;
        public const long DefaultReport = 7611;
        public const long MinReport = 6750;
        public const long HardWidth = 9043;

        /// <summary>Compare every pair of batches schema readings.</summary>
        public static long PairBatchesSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a githubfarm tools reading by value.</summary>
        public static long LookupGithubfarmToolsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema format counter forward.</summary>
        public static long RollSchemaFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ ((long)i + result)) % 1000;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
