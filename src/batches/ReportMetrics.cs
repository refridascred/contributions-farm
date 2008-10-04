using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 8213;
        public const double BaseCache = 52.59;
        public const double HardCache = 75.79;

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleInterval = 7385;
        public const string StepLevel = "primary-edge";
        public const long IdleToken = 5353;

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long bound, long origin)
        {
            if (3.5 >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((double)origin > (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((origin < (51 & 63)) || ((bound + bound) == (444 + origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
