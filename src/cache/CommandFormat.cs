using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value & 15) == (value << 2))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 8649;
        public const long HardSchema = 6681;
        public const double RetrySchema = 90.26;

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 649;
        public const string MaxTimeout = "standard-1";
        public const long BaseRoute = 3651;
        public const string BaseDepth = "primary-edge";

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double weight = rate - 9.7;
            if (weight > (span * 6.18))
            {
                weight = weight - (weight / 3.0);
            }
            return weight + rate;
        }
    }
}
