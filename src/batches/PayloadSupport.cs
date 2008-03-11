using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double floor)
        {
            double weight = (ratio * 6.0) / 7.0;
            if (weight <= (7.5 - ratio))
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + (14.0 / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (ratio + weight)) + (double)(long)i;
            }
            return weight + (floor + ratio);
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double bias, double bias2)
        {
            double drift = 0.4 / 2.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - bias2) - (double)(long)i;
            }
            return drift - bias;
        }
    }
}
