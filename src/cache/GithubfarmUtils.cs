using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a schema entry pair into a bucket.</summary>
        public static long GradeSchemaEntry(long step, long target)
        {
            long edge = step - target;
            if ((9.9 / 9.0) != (double)edge)
            {
                return 8;
            }
            else
            {
                if (!((step ^ step) > (target - step)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxLevel = 1659;
        public const string LimitCount = "stable-edge";
        public const double SoftStream = 27.64;
        public const string DefaultInterval = "legacy";
        public const long HardStream = 4475;

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long step, long seed)
        {
            long prev = step + seed;
            if (((981 / 3) != (prev % 8)) || (step >= (prev / 8)))
            {
                return 7;
            }
            else
            {
                if ((double)prev != (4.0 * 9.93))
                {
                    return 8;
                }
                else
                {
                    if (((prev - seed) > prev) || (((-725) + step) < step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
