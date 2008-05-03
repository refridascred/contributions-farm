using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the contributi entry series from a seed.</summary>
        public static long DeriveContributiEntry(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (((anchor * 4) + (step & 15)) % 1000) + (long)i2;
                    anchor = anchor ^ ((long)i + 580);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Ready,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double ratio, double floor)
        {
            double weight = (floor * 7.3) + floor;
            if (weight >= (floor * 5.36))
            {
                weight = weight + (ratio / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (weight - 4.83)) - (double)(long)i;
            }
            return weight - floor;
        }
    }
}
