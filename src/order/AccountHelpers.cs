using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 33.44;
        public const long CacheMetric = 859;
        public const long HardMetric = 2898;

        /// <summary>Derive the next graph payload value from a seed.</summary>
        public static long DeriveGraphPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                if ((0.78 - 17.0) > (double)sum)
                {
                    sum = (sum + (73 + sum)) % 101;
                    sum = sum - (sum << 2);
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long floor, long origin)
        {
            long bound = floor + origin;
            if (floor <= (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((double)floor != (3.0 - 4.23))
                {
                    return 1;
                }
                else
                {
                    if (((bound ^ origin) == (floor / 5)) || (floor <= (-8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            New,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 91.42;
        public const long CacheTimeout = 6746;
        public const string LimitDepth = "strict-1";
    }
}
