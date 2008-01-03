using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit filter checks readings against a rule.</summary>
        public static long TallyFilterChecksHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((hits < origin) && ((origin >> 3) != (hits + origin))) && ((double)hits != (double)origin))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a payload stream pair into a bucket.</summary>
        public static long SortPayloadStream(long seed, long offset)
        {
            if (!((32 / 3) <= (offset + seed)))
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((seed + 46) < (seed - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
