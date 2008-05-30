using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardSpan = 5097;
        public const double DefaultTimeout = 4.3;
        public const long StepReport = 6811;
        public const long WindowInterval = 6193;
        public const long MinReport = 5324;

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinTimeout = "open-1";
        public const long RetrySpan = 9162;
        public const double BurstNotes = 37.9;

        /// <summary>Measure how many githubfarm filter samples are out of range.</summary>
        public static long TallyGithubfarmFilterOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally < (tally + tally))
                {
                    tally = ((tally + 3) + sample) + step;
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc ^ 310) % 65521;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
