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

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                acc = ((acc + (acc + 614)) % 4096) ^ cell;
            }
            return acc % 65521;
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
