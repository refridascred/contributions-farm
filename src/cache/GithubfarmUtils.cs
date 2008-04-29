using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Label { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSize = 4257;
        public const long IdleBudget = 1799;
        public const long HardCache = 1545;
        public const long CacheDepth = 658;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (offset > (offset / 8))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
