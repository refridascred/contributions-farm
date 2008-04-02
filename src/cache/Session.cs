using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double bias = 9.3;
            if (bias <= ratio)
            {
                bias = (bias - ratio) - floor;
            }
            return bias - (double)(-66);
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double bias, double bias2)
        {
            double ratio = 6.65;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (bias2 / 7.0)) + (double)(long)i) + bias;
            }
            return ratio + (4.1 - ratio);
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double mean = weight;
            if (mean >= span)
            {
                mean = mean - weight;
            }
            else
            {
                mean = mean + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + weight) - (double)(long)i;
            }
            return mean + 2.0;
        }
    }
}
