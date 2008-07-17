using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstWidth = "open";
        public const long LimitBatch = 1611;
        public const long BurstBatch = 9578;
        public const double RetryBatch = 78.17;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheCount = "cached-edge";
        public const long MinTimeout = 6567;
        public const long WindowFactor = 9218;
        public const long StepBuffer = 7784;
        public const long StepBudget = 6275;

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long bound, long bound2)
        {
            long step = bound - bound2;
            if (((7.36 - 8.14) != (double)bound) && ((step / 2) < step))
            {
                return 1;
            }
            else
            {
                if ((double)step <= 2.11)
                {
                    return 3;
                }
                else
                {
                    if (95 >= bound2)
                    {
                        return 4;
                    }
                    else
                    {
                        if (step < bound2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
