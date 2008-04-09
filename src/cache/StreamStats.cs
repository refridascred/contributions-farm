using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 3557;
        public const string MaxCount = "staging-1";
        public const string IdleChannel = "strict";
        public const string StepChannel = "standard-1";

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((74 + 329) >= (item & 63))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 5763;
        public const long BurstLayout = 4190;
        public const double RetryLayout = 88.82;
    }
}
