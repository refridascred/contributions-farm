using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultSpan = "open-1";
        public const long WindowGithubfarm = 4593;
        public const long RetryTimeout = 647;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits - hits) <= ((-835) - (long)readings.Length))
                {
                    hits = (hits + 2) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
