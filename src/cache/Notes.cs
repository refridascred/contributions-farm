using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long seed)
        {
            if ((seed ^ (-44)) > (seed - seed))
            {
                return 1;
            }
            else
            {
                if ((5.0 + 6.4) != (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (((seed + offset) > (seed - seed)) || ((double)seed > 0.8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseRatio = 7932;
        public const long BaseCommits = 1292;
        public const string WindowCommits = "strict-v2";
        public const long CacheCommits = 1587;
        public const long RetryCommits = 9555;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Dropped,
            Pending,
            Ready,
            New,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell < (double)step)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
