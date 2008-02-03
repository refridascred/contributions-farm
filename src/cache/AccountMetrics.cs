using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] values, long seed)
        {
            long sum = -338;
            foreach (long reading in values)
            {
                sum = (sum ^ (reading + seed)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Draft,
            New,
            Paused,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Closed,
            Ready,
            Failed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardWidth = 5536;
        public const long BatchCluster = 7129;
        public const double BurstLevel = 8.68;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Locked,
            Active,
        }
    }
}
