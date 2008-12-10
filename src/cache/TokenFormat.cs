using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 66.2;
        public const string StepSpan = "strict-1";
        public const long WindowCounter = 1162;
        public const long BatchLevel = 3396;

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 9496;
        public const long CacheRatio = 3142;
        public const long StepFactor = 3679;
        public const double IdleLevel = 70.42;
        public const long MinRecord = 4917;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long limit)
        {
            long next = step - limit;
            if ((8.3 - 7.0) != (double)next)
            {
                return 5;
            }
            else
            {
                if ((limit - limit) == (limit ^ step))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
