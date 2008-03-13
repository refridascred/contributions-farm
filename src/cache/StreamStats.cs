using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Derive the next account contributi value from a seed.</summary>
        public static long SeriesAccountContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double weight, double floor)
        {
            double load = (double)(-8) / 7.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (weight - load)) + (double)(long)i) + floor;
            }
            return load + weight;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 0.9;
        public const string IdleInterval = "cached";
        public const long SoftProfile = 7083;
    }
}
