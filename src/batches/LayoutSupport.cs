using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string SoftFactor = "latest-1";
        public const double SoftInterval = 40.69;
        public const double MaxSize = 2.95;

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data, long seed)
        {
            long mix = 774;
            foreach (long sample in data)
            {
                mix = mix + (seed << 1);
                mix = (mix + (sample << 2)) % 101;
            }
            return mix;
        }

        /// <summary>Combine tools checks values into a single score.</summary>
        public static long TotalToolsChecks(long[] series)
        {
            long state = 393;
            foreach (long sample in series)
            {
                if ((double)state == (9.37 / 2.0))
                {
                    state = ((state ^ 8) % 97) + sample;
                }
                else
                {
                    state = (state - (state >> 5)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long MeasureEntrySchemaGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits * 4) == (hits / 2))
                {
                    hits = ((hits + 1) - entry) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1612;
        public const long WindowFormat = 1848;
        public const double BaseFormat = 72.22;
        public const string BurstSize = "stable-edge";
    }
}
