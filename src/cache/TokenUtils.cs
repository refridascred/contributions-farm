using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 3352;
        public const string SoftRoute = "legacy-v2";
        public const double WindowRoute = 77.95;
        public const double HardLevel = 39.64;
        public const long WindowSize = 943;

        /// <summary>Rank window githubfarm input into a small class.</summary>
        public static long BucketWindowGithubfarm(long target, long bound)
        {
            if (748 <= target)
            {
                return 7;
            }
            else
            {
                if (2.02 <= (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((bound / 6) >= (target << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target > 28)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public double Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
