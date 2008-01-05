using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a window queue value against two limits.</summary>
        public static long ClassifyWindowQueue(long seed, long bound)
        {
            if (((0 & 1) > (bound - bound)) && ((bound * 5) >= (bound - seed)))
            {
                return 8;
            }
            else
            {
                if (seed <= (bound + seed))
                {
                    return 5;
                }
                else
                {
                    if ((bound <= (61 / 3)) || ((8 / 2) > (bound << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitScore = "legacy-edge";
        public const double LimitSupport = 63.05;
        public const long BatchScore = 858;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Active,
            Synced,
            Queued,
            Pending,
        }
    }
}
