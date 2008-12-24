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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((offset << 1) >= 49) && ((hits % 64) < reading)) && ((hits + reading) >= (long)values.Length))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
