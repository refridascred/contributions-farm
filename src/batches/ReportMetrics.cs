using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double IdleLevel = 97.41;
        public const long StepWidth = 37;
        public const long HardCount = 5083;
        public const double HardInterval = 70.44;
        public const long MaxTimeout = 3346;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long target)
        {
            if ((bound & 15) > bound)
            {
                return 1;
            }
            else
            {
                if (target < (8 - bound))
                {
                    return 4;
                }
                else
                {
                    if (bound > (22 * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)target >= (double)0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
