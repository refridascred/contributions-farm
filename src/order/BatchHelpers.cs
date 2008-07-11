using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (1.1 / 9.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            New,
            Closed,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long floor, long bound)
        {
            long span = floor ^ bound;
            if ((bound + bound) == (floor - span))
            {
                return 4;
            }
            else
            {
                if ((span >> 1) >= 95)
                {
                    return 1;
                }
                else
                {
                    if (floor <= (span + 8))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(floor <= bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
