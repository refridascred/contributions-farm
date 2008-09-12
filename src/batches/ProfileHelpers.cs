using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinBudget = 199;
        public const long BaseSize = 2245;
        public const double IdleContext = 51.58;
        public const double RetrySize = 63.97;
        public const long BatchSpan = 1219;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long floor, long target)
        {
            long lane = floor - target;
            if ((lane + floor) == (target ^ lane))
            {
                return 7;
            }
            else
            {
                if ((lane + lane) >= (-77))
                {
                    return 2;
                }
                else
                {
                    if ((lane - target) < (floor >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((215 * 2) < hits))
                {
                    hits = ((hits + 1) + reading) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] values, long target)
        {
            long sum = 9;
            foreach (long item in values)
            {
                if ((target + target) < (sum * 2))
                {
                    sum = ((sum << 2) ^ (sum + target)) ^ item;
                }
            }
            return sum;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Locked,
            Ready,
        }
    }
}
