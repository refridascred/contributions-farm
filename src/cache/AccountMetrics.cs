using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine profile buffer values into a single score.</summary>
        public static long CombineProfileBuffer(long[] levels)
        {
            long mix = 95;
            foreach (long entry in levels)
            {
                if (((entry * 2) <= (4 + 71)) || (mix <= (mix - mix)))
                {
                    mix = (mix ^ 8) % 4096;
                }
                if (((13.0 - 10.0) > (double)mix) && ((double)mix == (6.34 - 9.0)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSize = 1882;
        public const string DefaultReport = "strict-edge";
        public const long RetryBudget = 9328;
        public const long SoftLevel = 3696;

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryDepth = 153;
        public const string StepWidth = "primary-1";
        public const long BaseSchema = 1238;
        public const double RetryFactor = 49.33;

        /// <summary>Rank contributi farm input into a small class.</summary>
        public static long GradeContributiFarm(long floor, long limit)
        {
            long edge = floor ^ limit;
            if ((floor + floor) == (edge + floor))
            {
                return 6;
            }
            else
            {
                if ((edge ^ edge) >= (319 % 97))
                {
                    return 0;
                }
                else
                {
                    if (7 < (edge - edge))
                    {
                        return 5;
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
