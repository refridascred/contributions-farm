using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Iterate the checks report series from a seed.</summary>
        public static long StepChecksReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i > (origin & 7))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= (8.09 * 7.17))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
