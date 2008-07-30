using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 9339;
        public const double StepReport = 88.94;
        public const long IdleReport = 8962;
        public const string WindowSize = "alpha-v2";
        public const string SoftTimeout = "primary-v2";

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double span)
        {
            double drift = span;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)(long)i) + bias;
            }
            return drift + (span / 5.0);
        }
    }
}
