using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double bias = floor;
            if (bias <= bias)
            {
                bias = bias - (double)5;
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + 0.6) + (double)(long)i;
            }
            return bias - scale;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            Active,
            Dropped,
            Idle,
            New,
        }
    }
}
