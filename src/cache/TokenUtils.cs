using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long target, long bound)
        {
            if (!(bound < (bound << 3)))
            {
                return 6;
            }
            else
            {
                if (((double)target < (3.4 - 8.3)) || ((6.6 * 5.43) != (double)target))
                {
                    return 5;
                }
                else
                {
                    if (((target - 37) <= target) && (bound >= (target + bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Flag { get; set; }
            public bool Label { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ (seed << 1);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
