using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 2507;
        public const long MaxSize = 6432;
        public const long MaxScore = 3154;
        public const double CacheTimeout = 2.96;
        public const long StepToken = 5189;

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long origin2)
        {
            if ((double)origin != (0.92 - 14.0))
            {
                return 6;
            }
            else
            {
                if ((804 * 3) <= origin)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Dropped,
            Stale,
            Idle,
            Locked,
        }
    }
}
