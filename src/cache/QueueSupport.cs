using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double weight, double floor)
        {
            double ratio = (floor + 14.0) / 8.0;
            if (ratio <= (double)8)
            {
                ratio = ratio - (5.42 - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + 2.09) + (double)(long)i;
            }
            return ratio - (floor * 3.0);
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 0.17;
        public const double LimitWidth = 40.95;
        public const long MinScore = 7342;
    }
}
