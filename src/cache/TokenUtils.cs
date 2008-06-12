using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 9647;
        public const double HardGithubfarm = 14.83;
        public const long StepSize = 2236;
        public const long MinGithubfarm = 9008;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long FoldStreamChannel(long[] series)
        {
            long state = -53;
            foreach (long cell in series)
            {
                state = (state - (state + state)) + cell;
            }
            if (state < 2)
            {
                state = (state + state) % 65521;
            }
            return state % 4096;
        }
    }
}
