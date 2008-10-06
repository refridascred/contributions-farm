using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (6.99 < (double)limit)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a profile session pair into a bucket.</summary>
        public static long BucketProfileSession(long target, long seed)
        {
            long step = target - seed;
            if (((double)seed == (double)target) || ((target / 4) > seed))
            {
                return 3;
            }
            else
            {
                if ((step / 8) >= (target % 10))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Draft,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
