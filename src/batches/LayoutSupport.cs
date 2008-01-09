using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine metrics stats values into a single score.</summary>
        public static long TallyMetricsStats(long[] data)
        {
            long acc = 386;
            foreach (long reading in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc - (reading & 1)) ^ (long)i;
                }
                if ((reading >= (7 + acc)) || ((11.0 + 6.6) > (double)acc))
                {
                    acc = acc ^ (acc + 497);
                }
                else
                {
                    acc = (acc + ((-267) ^ acc)) % 101;
                }
                if ((double)reading >= (5.0 + 9.0))
                {
                    acc = (acc - (reading / 2)) % 1000;
                }
            }
            if (acc > 93)
            {
                acc = acc + (acc % 8);
            }
            return acc;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double gain2 = (double)((-37) + 794);
            if (gain2 > (3.95 + gain2))
            {
                gain2 = gain2 + floor;
            }
            else
            {
                gain2 = gain2 + (double)(-4);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + floor) + (double)(long)i;
            }
            return gain2 + gain;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public bool Token { get; set; }
        }
    }
}
