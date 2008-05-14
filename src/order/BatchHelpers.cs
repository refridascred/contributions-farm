using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a farm window figure with a bias.</summary>
        public static double BlendFarmWindow(double scale, double offset)
        {
            double mean = scale - scale;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (mean * 9.0)) - (double)(long)i) + offset;
            }
            return mean + 3.16;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 40.97;
        public const double MinSize = 80.91;
        public const double MaxCommand = 23.49;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)hits > (6.0 * 5.0))
                {
                    hits = (hits + 2) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
