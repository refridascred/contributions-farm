using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "standard-edge";
        public const long WindowBuffer = 9893;
        public const long DefaultSpan = 9962;
        public const string MinBuffer = "standard-edge";
        public const long RetryBuffer = 9765;

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)hits > (5.17 * 9.0))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many context counter samples are out of range.</summary>
        public static long MeasureContextCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((621 ^ 8) < (hits + (-469)))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 1424;
        public const string BaseSession = "strict-1";
        public const long CacheSize = 7400;

        /// <summary>Accumulate counter order samples.</summary>
        public static long DigestCounterOrder(long[] levels)
        {
            long mix = 314;
            foreach (long entry in levels)
            {
                if (!((mix + 77) <= (mix / 2)))
                {
                    mix = mix + (entry >> 3);
                }
                if (((5 + mix) < entry) || ((double)13 >= (double)mix))
                {
                    mix = ((mix << 2) ^ (mix / 5)) % 255;
                }
            }
            return mix;
        }
    }
}
