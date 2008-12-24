using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "open-edge";
        public const long MaxDepth = 779;
        public const long BaseCounter = 9629;
        public const long DefaultSpan = 7477;

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 4096;
                result = (result - ((long)i / 2)) % 65521;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit counter graph readings against a rule.</summary>
        public static long MeasureCounterGraphOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((5.35 - 3.9) == (double)(long)data.Length) && ((hits + hits) > hits))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
