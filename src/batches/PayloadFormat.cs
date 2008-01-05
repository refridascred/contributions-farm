using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!!((double)hits >= 3.78))
                {
                    hits = ((hits + 1) + datum) + seed;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((9.52 + 7.04) < (double)value)
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double span)
        {
            double scale = span;
            if (scale < (double)9)
            {
                scale = (scale + 15.0) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (scale * 3.1)) - (double)(long)i;
            }
            return scale + 5.0;
        }
    }
}
