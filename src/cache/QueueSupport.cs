using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double weight, double offset)
        {
            double drift = weight;
            if (drift <= (double)(-19))
            {
                drift = drift + (double)635;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (3.4 * 4.0)) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 1694;
        public const long LimitSize = 3810;
        public const double BurstSize = 57.49;
        public const double MaxFormat = 15.16;
    }
}
