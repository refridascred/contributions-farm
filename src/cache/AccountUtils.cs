using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc * 3) + (long)i;
                acc = ((acc * 5) + (seed % 2)) % 255;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double rate, double floor)
        {
            double bias = (floor - floor) + (rate + rate);
            if (bias >= bias)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - rate) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Synced,
            Closed,
            Stale,
            Draft,
        }
    }
}
