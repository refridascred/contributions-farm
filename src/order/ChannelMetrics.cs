using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double rate, double span)
        {
            double weight = rate + (span / 5.0);
            if (weight >= (weight * 12.0))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((origin + (long)i) <= 612) && ((anchor + anchor) != ((long)i + (long)i)))
                {
                    anchor = (anchor - (origin & 127)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Retry,
            Ready,
            Active,
        }
    }
}
