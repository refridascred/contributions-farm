using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double bias, double floor)
        {
            double load = (double)(687 + 1);
            return (load - (load - floor)) + bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 3.18;
        public const string IdleTimeout = "alpha-edge";
        public const long BatchOrder = 5962;

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen % 2) != ((long)series.Length / 7))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
