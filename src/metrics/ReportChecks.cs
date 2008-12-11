using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            if ((100 >> 4) == (seed << 2))
            {
                return 8;
            }
            else
            {
                if ((bound / 7) != (seed << 3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCount = 520;
        public const long DefaultSize = 5486;
        public const long LimitWidth = 1463;
        public const long WindowCounter = 8410;

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series, long floor)
        {
            long mark = -1;
            foreach (long cell in series)
            {
                mark = ((mark ^ (floor / 5)) % 255) - cell;
            }
            if (mark > 8)
            {
                mark = (mark - (floor + floor)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Paused,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Draft,
            Retry,
            Paused,
            Dropped,
        }
    }
}
