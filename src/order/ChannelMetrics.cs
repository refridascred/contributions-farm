using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Roll a already cluster counter forward.</summary>
        public static long StepAlreadyCluster(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor + ((long)i2 >> 2)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double gain, double floor)
        {
            double weight = (gain / 4.0) / 6.0;
            if (weight < (floor * 16.0))
            {
                weight = weight + (floor * 5.5);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - floor;
        }
    }
}
