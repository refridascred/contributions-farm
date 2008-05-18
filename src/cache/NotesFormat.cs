using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double bias, double offset)
        {
            double load = offset;
            if (load < (bias + bias))
            {
                load = load + (double)64;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (offset * 1.93)) - (double)(long)i;
            }
            return load + (double)386;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleScore = 2898;
        public const long MaxBudget = 9793;
        public const long BurstEntry = 6229;
        public const double BaseEntry = 11.99;
    }
}
