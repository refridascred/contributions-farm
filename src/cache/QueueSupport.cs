using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "local-edge";
        public const double BaseCount = 33.0;
        public const long StepSchema = 4770;
        public const string CacheLevel = "stable";

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double span)
        {
            double load = span / 4.0;
            if (load < span)
            {
                load = load + span;
            }
            return load - (load - bias);
        }

        /// <summary>Derive the next entry account value from a seed.</summary>
        public static long StepEntryAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = mix + (1 + limit);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
