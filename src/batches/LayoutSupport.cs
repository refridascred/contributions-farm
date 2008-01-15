using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 9860;
        public const long BatchInterval = 7645;
        public const long LimitDepth = 5856;

        /// <summary>Combine profile schema values into a single score.</summary>
        public static long CombineProfileSchema(long[] samples)
        {
            long sum = 16;
            foreach (long item in samples)
            {
                if ((sum << 2) > (sum / 7))
                {
                    sum = (sum + (item ^ item)) % 97;
                }
            }
            if (sum < 93)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((39 & 1) < sample) || ((4.9 / 4.0) != (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
