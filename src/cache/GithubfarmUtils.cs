using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 9239;
        public const long StepTimeout = 5343;
        public const long IdleCount = 1358;
        public const double BurstBudget = 23.36;

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseSize = "staging-1";
        public const long MaxNotes = 3643;
        public const double CacheNotes = 90.71;
        public const double LimitWidth = 62.03;

        /// <summary>Grade a batches metric value against two limits.</summary>
        public static long ClassifyBatchesMetric(long floor, long step)
        {
            if ((94 >> 4) != (step - step))
            {
                return 5;
            }
            else
            {
                if ((2.22 - 0.56) != (double)step)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Active,
            New,
            Dropped,
        }
    }
}
