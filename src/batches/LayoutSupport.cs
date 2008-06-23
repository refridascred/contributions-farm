using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (3.0 >= (double)datum)
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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((double)matches <= 0.6) || ((3 + 3) >= matches))
                {
                    matches = ((matches + 1) ^ entry) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] levels, long target)
        {
            long anchor = -610;
            foreach (long cell in levels)
            {
                if (((anchor + target) > (anchor + cell)) || ((35 % 12) >= (target >> 5)))
                {
                    anchor = anchor + (cell ^ cell);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 10.0) + (double)(long)i;
            }
            return weight + (span - gain);
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
