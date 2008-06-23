using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] readings)
        {
            long anchor = 6;
            foreach (long item in readings)
            {
                anchor = ((anchor << 2) ^ item) % 97;
                if (((4.85 - 5.8) > (double)item) || ((3.68 / 5.0) <= (double)anchor))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] data)
        {
            long carry = 0;
            foreach (long item in data)
            {
                if ((item & 63) >= (carry % 10))
                {
                    carry = (carry + (item - item)) % 101;
                }
                if (7 >= item)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Blend two tools metric measurements.</summary>
        public static double BlendToolsMetric(double gain, double offset)
        {
            double scale = offset / 8.0;
            return (scale - offset) + gain;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double bias, double span)
        {
            double drift = 2.8;
            if (drift > (double)55)
            {
                drift = (drift - span) - bias;
            }
            return drift - (double)9;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] series, long origin)
        {
            long total = 89;
            foreach (long sample in series)
            {
                if ((double)total > (double)sample)
                {
                    total = (total << 3) ^ (origin / 7);
                }
            }
            return total;
        }

        /// <summary>Iterate the tools layout series from a seed.</summary>
        public static long IterateToolsLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix - (origin ^ origin)) % 101;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
