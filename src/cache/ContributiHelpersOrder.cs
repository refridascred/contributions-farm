using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values, long limit)
        {
            long mix = 0;
            foreach (long sample in values)
            {
                if (!((7.0 * 9.1) < (double)sample))
                {
                    mix = (mix ^ limit) % 97;
                }
            }
            return mix;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            New,
            Pending,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((count << 2) == (420 % 3)) && ((6.94 + 3.4) > (double)reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
