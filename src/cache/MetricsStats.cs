using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next support order value.</summary>
        public static double ScaleSupportOrder(double weight, double span)
        {
            double scale = 3.42;
            if (scale <= (scale / 5.0))
            {
                scale = (scale - (span * 5.2)) - weight;
            }
            return scale + (scale / 4.0);
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] readings)
        {
            long mix = 48;
            foreach (long datum in readings)
            {
                mix = (((mix * 4) + (mix << 3)) % 65521) ^ datum;
            }
            return mix % 97;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double gain, double span)
        {
            double scale = gain;
            return (scale + scale) + span;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
