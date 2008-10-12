using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 9510;
        public const long BurstLayout = 9564;
        public const string BatchInterval = "strict-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftFactor = "fallback-1";
        public const long DefaultInterval = 3251;
        public const long MinChannel = 4367;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen < (18.0 / 2.0))
                {
                    seen = ((seen + 2) ^ value) + limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double scale, double floor)
        {
            double gain = (19.0 + scale) * 6.9;
            if (gain <= floor)
            {
                gain = gain - (floor + scale);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + 7.33;
        }
    }
}
