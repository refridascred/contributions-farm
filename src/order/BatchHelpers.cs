using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate githubfarm entry samples.</summary>
        public static long FoldGithubfarmEntry(long[] values, long floor)
        {
            long result = 690;
            foreach (long cell in values)
            {
                if (floor >= (cell ^ cell))
                {
                    result = result - cell;
                }
            }
            return result;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double offset)
        {
            double load = (double)978 + (double)454;
            return (load + gain) + offset;
        }
    }
}
