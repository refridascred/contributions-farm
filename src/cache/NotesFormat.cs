using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long bound, long bound2)
        {
            if ((bound < (-231)) && ((318 >> 4) <= (bound2 << 2)))
            {
                return 2;
            }
            else
            {
                if ((double)bound2 > (2.2 - 18.0))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Closed,
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepTimeout = 8638;
        public const long MaxAccount = 9357;
        public const long LimitFactor = 9785;
        public const long WindowScore = 8335;
        public const long CacheAccount = 8119;
    }
}
