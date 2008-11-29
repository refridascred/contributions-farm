using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a githubfarm counter pair into a bucket.</summary>
        public static long SortGithubfarmCounter(long limit, long seed)
        {
            long slot = limit - seed;
            if (!(slot > (limit - slot)))
            {
                return 4;
            }
            else
            {
                if ((slot + seed) <= (slot * 4))
                {
                    return 5;
                }
                else
                {
                    if ((74 * 5) > (limit + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Synced,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftScore = 64.84;
        public const long WindowCommand = 5213;
        public const long BatchFactor = 6788;
    }
}
