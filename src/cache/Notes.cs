using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a payload contributi reading by value.</summary>
        public static long SeekPayloadContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate editor schema readings against a bound.</summary>
        public static bool ValidateEditorSchemaLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double bias)
        {
            double scale = bias;
            if (scale < ratio)
            {
                scale = scale + (bias - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + 2.57) + (double)(long)i;
            }
            return scale - (double)28;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((((hits ^ bound) > (entry % 100)) && ((entry - bound) < hits)) && ((bound - bound) >= bound))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
