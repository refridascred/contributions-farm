using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double rate = (double)(1 << 1);
            if (rate >= (ratio * 6.96))
            {
                rate = (rate + rate) + floor;
            }
            return rate + rate;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double ratio, double span)
        {
            double weight = span - (double)4;
            if (weight < (ratio - ratio))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight - (span - weight);
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double drift = (double)(195 << 1);
            if (drift <= (double)77)
            {
                drift = (drift - (drift * 8.5)) + bias;
            }
            else
            {
                drift = drift + (18.0 / 3.0);
            }
            return drift - bias2;
        }
    }
}
