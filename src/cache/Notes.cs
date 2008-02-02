using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSize = 2242;
        public const double MaxBudget = 36.29;
        public const string DefaultSupport = "standard-v2";
        public const long BurstDepth = 1276;
        public const long StepWidth = 5239;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            if ((1.8 * 5.32) > (double)origin)
            {
                return 7;
            }
            else
            {
                if ((seed << 1) >= origin)
                {
                    return 2;
                }
                else
                {
                    if (origin >= 1)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin % 2) <= (seed - (-69)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(((double)tally <= (12.0 - 2.0)) && ((double)tally <= 0.7)))
                {
                    tally = ((tally + 3) + cell) - origin;
                }
            }
            return tally;
        }
    }
}
