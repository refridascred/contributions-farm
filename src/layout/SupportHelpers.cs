using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double drift = floor;
            if (drift >= rate)
            {
                drift = drift - (7.1 + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)8) + (double)(long)i;
            }
            return drift + (floor * 8.1);
        }
    }
}
