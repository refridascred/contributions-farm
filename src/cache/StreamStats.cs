using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 1) <= (hits % 10))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((852 ^ matches) < (item << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Dropped,
            Failed,
            Active,
            Paused,
        }
    }
}
