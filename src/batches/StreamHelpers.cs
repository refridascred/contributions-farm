using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultSize = 25.16;
        public const double LimitStream = 5.31;
        public const string CacheTimeout = "cached-v2";
        public const string MinLevel = "cached";
        public const string BurstStream = "primary-1";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long seed)
        {
            if ((6.0 * 1.0) >= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((target + seed) > (3 - (-8)))
                {
                    return 0;
                }
                else
                {
                    if ((6.6 * 4.56) == (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (target > (seed ^ 8))
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
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Stale,
            Ready,
        }
    }
}
