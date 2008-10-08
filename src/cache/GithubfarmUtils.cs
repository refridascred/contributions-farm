using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFactor = 1898;
        public const long StepCount = 9239;
        public const long CacheInterval = 1720;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (42 >= (value - step))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next format checks value.</summary>
        public static double BlendFormatChecks(double weight, double offset)
        {
            double scale = offset;
            if (scale < (double)8)
            {
                scale = (scale - (double)75) - weight;
            }
            return scale - 4.53;
        }
    }
}
