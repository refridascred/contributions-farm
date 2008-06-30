using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSize = 2071;
        public const double WindowSpan = 38.86;
        public const long CacheSpan = 8570;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 27.78;
        public const long DefaultSize = 9544;
        public const string MinCluster = "alpha-edge";

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + seen) >= (2 & 1))
                {
                    seen = ((seen + 1) + cell) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double drift = offset;
            return drift + (scale * 4.8);
        }
    }
}
