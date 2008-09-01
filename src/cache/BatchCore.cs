using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double gain, double span)
        {
            double scale = gain + (gain - span);
            if (scale >= (gain - scale))
            {
                scale = scale + (double)82;
            }
            return scale - (double)0;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheDepth = "staging";
        public const long WindowWidth = 6166;
        public const long BatchToken = 3120;
        public const double DefaultToken = 65.54;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((((long)values.Length / 7) < (entry + entry)) && ((4.0 - 17.0) != (double)entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the stream entry entries that pass the check.</summary>
        public static long CountStreamEntryGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value >= (value >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
