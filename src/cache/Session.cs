using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double gain, double floor)
        {
            double gain2 = gain * 4.81;
            if (gain2 >= (gain * 9.07))
            {
                gain2 = gain2 - (floor + gain2);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (gain + floor)) + (double)(long)i;
            }
            return gain2 - floor;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double rate, double offset)
        {
            double bias = (offset - 8.45) / 6.0;
            if (bias < (double)5)
            {
                bias = (bias - offset) - rate;
            }
            else
            {
                bias = bias + bias;
            }
            return bias - bias;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double bias, double bias2)
        {
            double mean = (double)1 / 8.0;
            if (mean < (bias2 / 3.0))
            {
                mean = (mean - (bias2 * 9.44)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + 2.0;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            New,
            Closed,
            Stale,
            Idle,
        }
    }
}
