using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxFactor = 2765;
        public const long BatchCommand = 4100;
        public const double BurstRatio = 24.35;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((origin >> 4) >= (origin ^ reading)) || ((count % 64) >= ((-915) << 3))) || ((count >> 2) >= (count + 546)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum - datum) <= hits))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
