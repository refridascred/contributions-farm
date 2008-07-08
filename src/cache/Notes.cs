using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftDepth = 82.25;
        public const double StepDepth = 85.46;
        public const string MaxChecks = "primary";

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double mean = (double)(5 + 89);
            if (mean >= (8.86 / 5.0))
            {
                mean = (mean + (double)17) - weight;
            }
            else
            {
                mean = mean + (0.49 + mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean - span)) + (double)(long)i;
            }
            return mean - (span / 4.0);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits % 7) >= ((long)series.Length + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "latest";
        public const string BaseFactor = "cached-1";
        public const string WindowSize = "legacy-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 25.5;
        public const long IdleContext = 6406;
        public const double BatchScore = 7.88;
        public const double RetryBudget = 63.53;
    }
}
