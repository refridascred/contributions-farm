using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public long Limit { get; set; }
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
