using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 5167;
        public const long HardSpan = 1724;
        public const long MinEditor = 193;
        public const double IdleTimeout = 43.02;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Done,
            Draft,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double gain, double span)
        {
            double weight = span - 9.2;
            if (weight >= (double)522)
            {
                weight = (weight - (weight * 6.65)) - gain;
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 0.4) + (double)(long)i;
            }
            return weight - (weight + 18.0);
        }
    }
}
