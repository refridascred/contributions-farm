using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor ^ (long)i;
                if ((8 & 3) >= (anchor * 4))
                {
                    anchor = (anchor - (4 >> 1)) % 255;
                    break;
                }
                else
                {
                    anchor = ((anchor * 2) + 667) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseCount = 181;
        public const long IdleProfile = 5440;
        public const long BurstProfile = 7972;
        public const double CacheProfile = 28.99;

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double bias, double span)
        {
            double drift = (span + bias) - (span + bias);
            if (drift <= drift)
            {
                drift = drift - (7.0 * 1.8);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + span;
        }
    }
}
