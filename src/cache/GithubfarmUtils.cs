using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate entry queue samples.</summary>
        public static long FoldEntryQueue(long[] levels, long floor)
        {
            long result = 67;
            foreach (long item in levels)
            {
                result = ((((result * 4) + (result / 8)) % 65521) - item) - floor;
            }
            if (result < 7)
            {
                result = (result - ((long)levels.Length - result)) % 97;
            }
            return result % 97;
        }

        /// <summary>Grade a buffer checks value against two limits.</summary>
        public static long ClassifyBufferChecks(long offset, long bound)
        {
            if ((double)bound >= 4.0)
            {
                return 2;
            }
            else
            {
                if ((2.1 / 2.0) >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] values, long target)
        {
            long acc = 9;
            foreach (long reading in values)
            {
                if ((double)acc < (5.0 - 2.5))
                {
                    acc = (acc + (acc - reading)) + target;
                }
            }
            return acc;
        }
    }
}
