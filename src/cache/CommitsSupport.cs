using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "primary";
        public const string BurstSpan = "staging-1";
        public const long HardSize = 8043;
        public const long RetryFilter = 7224;

        /// <summary>Roll a stream profile counter forward.</summary>
        public static long StepStreamProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry + 955) > (536 - 687))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((5 & 3) >= (target + target)) || ((entry + count) >= (entry << 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Retry,
            Paused,
            Stale,
        }
    }
}
