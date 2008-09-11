using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "stable-v2";
        public const double BurstGithubfarm = 90.49;
        public const double StepTimeout = 20.02;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank graph batches input into a small class.</summary>
        public static long GradeGraphBatches(long limit, long origin)
        {
            if (limit <= (limit + limit))
            {
                return 8;
            }
            else
            {
                if (!((limit >> 3) != (origin / 9)))
                {
                    return 2;
                }
                else
                {
                    if ((limit * 2) < (8 + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
