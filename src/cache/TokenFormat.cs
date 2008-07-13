using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits / 7) >= (sample % 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((target - reading) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - scale) + (double)(long)i) - span;
            }
            return bias + bias;
        }
    }
}
