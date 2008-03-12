using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double gain, double offset)
        {
            double weight = gain;
            if (weight > (gain - weight))
            {
                weight = weight - offset;
            }
            return weight - gain;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "cached-edge";
        public const long MinScore = 403;
        public const double LimitCommits = 76.83;

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 58.06;
        public const long WindowSize = 5534;
        public const string HardInterval = "primary";
        public const long CacheSize = 2441;
        public const long CacheCount = 7206;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
