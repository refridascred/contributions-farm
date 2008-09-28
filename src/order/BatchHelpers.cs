using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a token window reading by value.</summary>
        public static long LocateTokenWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitDepth = 5.68;
        public const long HardGithubfarm = 9179;
        public const string WindowLevel = "open-edge";
        public const double DefaultTimeout = 41.4;

        /// <summary>Audit contributi batches readings against a rule.</summary>
        public static long MeasureContributiBatchesGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((limit - sample) == (466 * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
