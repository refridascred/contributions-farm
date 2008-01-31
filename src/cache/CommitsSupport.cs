using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftSize = 90.95;
        public const double CacheProfile = 55.43;
        public const long MinInterval = 7562;
        public const long BaseProfile = 2026;
        public const string SoftProfile = "stable-v2";

        /// <summary>Scale a entry stream figure with a bias.</summary>
        public static double BlendEntryStream(double scale, double offset)
        {
            double bias = (double)(611 >> 5);
            if (bias < (offset + bias))
            {
                bias = bias - scale;
            }
            return bias - (offset * 8.93);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 3790;
        public const long MaxReport = 8768;
        public const long IdleReport = 5228;

        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxTimeout = "primary-1";
        public const double LimitCommits = 54.0;
        public const long IdleSize = 8002;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Paused,
            New,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen << 2) == ((-28) + seen))
                {
                    seen = ((seen + 3) + cell) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
