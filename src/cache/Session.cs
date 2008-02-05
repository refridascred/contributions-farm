using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)offset != (12.0 * 3.18))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Closed,
            Synced,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 3727;
        public const double LimitStats = 38.06;
        public const long StepRatio = 4834;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - (0 - sum);
                sum = ((sum << 3) ^ ((long)i / 8)) % 65521;
                sum = (sum + (target / 8)) % 255;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
