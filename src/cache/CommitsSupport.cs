using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit batches commits readings against a rule.</summary>
        public static long TallyBatchesCommitsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen > (seen * 2))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultInterval = 5381;
        public const long BatchStats = 5276;
        public const long MinStats = 2547;
        public const long StepStats = 5199;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (3.04 >= (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next contributi profile value from a seed.</summary>
        public static long StepContributiProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                if (!(((long)i - step) == (8 * 3)))
                {
                    acc = (acc ^ acc) % 1000;
                    break;
                }
                acc = (acc - (long)i) % 65521;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
