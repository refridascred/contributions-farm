using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next format metric value from a seed.</summary>
        public static long DeriveFormatMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc * 5) + (acc >> 4);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = total ^ (total & 63);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double ratio, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + (7.0 * 4.85);
        }
    }
}
