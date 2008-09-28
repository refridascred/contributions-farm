using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of farm batches readings.</summary>
        public static long FoldFarmBatches(long[] values)
        {
            long state = 44;
            foreach (long sample in values)
            {
                state = state - (state >> 5);
                if ((state >= (sample - sample)) || ((sample + state) > (state * 3)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long target)
        {
            long prev = bound - target;
            if ((prev ^ target) < bound)
            {
                return 6;
            }
            else
            {
                if ((target << 1) > prev)
                {
                    return 4;
                }
                else
                {
                    if (bound >= (target + prev))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((prev - prev) <= prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Active,
            Done,
            Pending,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultBudget = 71.63;
        public const double RetrySupport = 30.03;
        public const long WindowSupport = 5534;
        public const double CacheSupport = 58.92;
    }
}
