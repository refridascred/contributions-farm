using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double bias = ratio * 4.8;
            return (bias + (bias - ratio)) + offset;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = (total - origin) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
