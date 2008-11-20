using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double gain, double span)
        {
            double scale = gain;
            if (scale < (double)68)
            {
                scale = (scale - 9.0) - span;
            }
            return scale - scale;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits >> 2) >= 60)
                {
                    hits = ((hits + 2) ^ sample) + origin;
                }
            }
            return hits;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 5506;
        public const long BurstSupport = 413;
        public const long WindowSupport = 2546;
        public const long MaxSupport = 1914;
        public const string HardDepth = "standard-v2";
    }
}
