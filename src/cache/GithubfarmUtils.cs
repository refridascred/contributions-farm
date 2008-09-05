using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 2047;
        public const long RetryBuffer = 1811;
        public const long MaxRatio = 4058;
        public const long RetryScore = 2072;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long limit, long offset)
        {
            if ((limit + offset) > (offset / 6))
            {
                return 2;
            }
            else
            {
                if ((double)limit < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!((3.4 - 10.0) < (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

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
