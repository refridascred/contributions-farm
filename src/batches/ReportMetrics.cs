using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double gain = (double)(3 >> 4);
            if (gain <= (double)65)
            {
                gain = (gain + bias) - span;
            }
            else
            {
                gain = gain - (bias - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] data, long offset)
        {
            long anchor = 4;
            foreach (long item in data)
            {
                anchor = ((anchor << 2) ^ item) + offset;
            }
            return anchor;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
