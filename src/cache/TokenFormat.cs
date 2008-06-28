using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next metrics queue value from a seed.</summary>
        public static long DeriveMetricsQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a notes session figure with a bias.</summary>
        public static double SmoothNotesSession(double bias, double offset)
        {
            double load = (double)(16 << 3);
            return ((load + (double)51) + bias) + offset;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double bias, double floor)
        {
            double gain = floor * 7.59;
            if (gain >= (floor - floor))
            {
                gain = gain + (4.0 - bias);
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + 7.0) + (double)(long)i;
            }
            return gain - (double)71;
        }
    }
}
