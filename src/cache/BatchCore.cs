using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long floor)
        {
            if ((3.97 + 9.5) != (double)floor)
            {
                return 0;
            }
            else
            {
                if (((floor / 8) == (offset / 9)) && (offset <= (offset ^ floor)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1568;
        public const double BurstFactor = 86.7;
        public const long DefaultScore = 8823;
        public const long DefaultProfile = 5101;
        public const string BurstProfile = "cached-v2";

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Done,
            Draft,
        }
    }
}
