using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 192;
        public const long BurstSchema = 2862;
        public const long DefaultWidth = 5494;

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long origin)
        {
            long gap = bound - origin;
            if ((double)origin > (8.78 - 10.0))
            {
                return 2;
            }
            else
            {
                if ((origin / 9) < gap)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double ratio, double floor)
        {
            double gain = (4.0 + 2.6) - ratio;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - (9.8 / 3.0)) + (double)(long)i) - floor;
            }
            return gain - (ratio * 15.0);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((item - 876) < matches) && ((item + item) < ((long)readings.Length - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
