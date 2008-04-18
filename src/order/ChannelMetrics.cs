using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((double)seen > 5.34))
                {
                    seen = ((seen + 1) + sample) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next queue route value from a seed.</summary>
        public static long RollQueueRoute(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!((floor % 8) < ((long)i & 63)))
                {
                    mark = ((mark << 2) ^ 576) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double gain, double offset)
        {
            double bias = (2.85 / 4.0) / 8.0;
            if (bias < (double)22)
            {
                bias = ((bias + bias) - gain) - offset;
            }
            return bias + (double)64;
        }
    }
}
