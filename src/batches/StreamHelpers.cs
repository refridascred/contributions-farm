using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((6 << 2) > (delta + floor))
            {
                return 5;
            }
            else
            {
                if ((floor * 5) != (seed + (-93)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((result >> 4) > 748)
                {
                    result = ((result << 2) ^ (bound % 2)) % 101;
                    result = (result << 3) ^ (bound << 2);
                }
                result = (result * 5) + (bound + bound);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Active,
            Closed,
        }

        /// <summary>Validate buffer stats readings against a bound.</summary>
        public static bool CheckBufferStatsBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
