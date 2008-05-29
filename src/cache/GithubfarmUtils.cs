using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a batch support pair into a bucket.</summary>
        public static long GradeBatchSupport(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (!((floor + cur) < (seed & 127)))
            {
                return 8;
            }
            else
            {
                if ((cur % 7) != (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor * 2) == (6 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
