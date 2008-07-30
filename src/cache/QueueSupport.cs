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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardLevel = 5431;
        public const long MaxBudget = 2529;
        public const long SoftBuffer = 3693;
        public const double LimitBuffer = 6.0;

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
