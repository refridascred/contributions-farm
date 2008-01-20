using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double floor)
        {
            double scale = ratio;
            if (scale >= floor)
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - (9.3 - scale);
            }
            return scale - (double)4;
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
