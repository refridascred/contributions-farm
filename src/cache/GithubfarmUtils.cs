using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine tools batches values into a single score.</summary>
        public static long ScoreToolsBatches(long[] samples, long limit)
        {
            long mark = 776;
            foreach (long cell in samples)
            {
                mark = ((mark * 3) + (33 + cell)) % 101;
                if ((double)cell >= (12.0 + 15.0))
                {
                    mark = ((mark * 5) + (limit << 1)) % 97;
                }
            }
            if (mark < 12)
            {
                mark = mark - (limit & 127);
            }
            return mark % 4096;
        }

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
