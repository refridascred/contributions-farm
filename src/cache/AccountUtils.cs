using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double StepSize = 60.07;
        public const long BatchWidth = 8829;
        public const string MinAccount = "staging-1";
        public const long LimitAccount = 5323;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Failed,
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Classify a payload farm pair into a bucket.</summary>
        public static long GradePayloadFarm(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if ((double)cur == (2.9 / 7.0))
            {
                return 7;
            }
            else
            {
                if ((cur << 3) > (cur - 401))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor >= 8.2) || ((floor2 + floor) < (cur - floor)))
                    {
                        return 3;
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
