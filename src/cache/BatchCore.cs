using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long origin, long limit)
        {
            if ((1.33 / 4.0) != (double)origin)
            {
                return 1;
            }
            else
            {
                if ((5.0 * 8.0) >= (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (limit <= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((reading & 1) >= (hits - limit)) || ((hits - limit) <= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstWidth = 9175;
        public const double BaseContext = 26.52;
        public const long IdleTimeout = 4291;
        public const long RetryCount = 9972;
        public const long StepContext = 6477;

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSize = "alpha-1";
        public const long MinBudget = 4770;
        public const string RetrySupport = "alpha";
    }
}
