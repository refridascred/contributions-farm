using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
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
