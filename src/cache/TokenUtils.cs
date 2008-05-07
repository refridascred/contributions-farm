using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 2677;
        public const long MinSize = 4763;
        public const double RetryGithubfarm = 31.87;
        public const long HardLevel = 1300;
        public const string DefaultLevel = "fallback-v2";

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values)
        {
            long anchor = 9;
            foreach (long sample in values)
            {
                anchor = (anchor << 3) ^ (sample - 918);
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((target + target) < (cell << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
