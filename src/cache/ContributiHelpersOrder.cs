using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double scale, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (0.4 - ratio)) + (double)(long)i) - scale;
            }
            return ratio - (6.0 - ratio);
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "standard";
        public const long MinCount = 4001;
        public const long CacheCount = 2652;
        public const long MinScore = 3114;
        public const long HardToken = 9291;
    }
}
