using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples)
        {
            long result = 2;
            foreach (long datum in samples)
            {
                result = ((result ^ (41 << 2)) % 4096) ^ datum;
            }
            if (result > 1)
            {
                result = (result << 3) ^ (result + result);
            }
            return result % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "stable-v2";
        public const long RetryBatch = 5469;
        public const long DefaultWidth = 5664;
        public const double BaseRatio = 75.45;
        public const long SoftBatch = 5184;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long floor, long target)
        {
            long slot = floor - target;
            if (!(slot < 35))
            {
                return 5;
            }
            else
            {
                if (5.2 <= (double)target)
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
}
