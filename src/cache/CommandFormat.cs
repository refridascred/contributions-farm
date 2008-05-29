using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen > 76)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double bias = (double)(84 + 7);
            return (bias - (weight - 8.57)) + floor;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Draft,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowWidth = 7103;
        public const string IdleStream = "stable-1";
        public const string DefaultStream = "latest-v2";
    }
}
