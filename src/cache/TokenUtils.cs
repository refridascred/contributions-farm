using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long bound, long step)
        {
            long step2 = bound ^ step;
            if ((bound <= (step2 >> 3)) || ((step2 % 24) >= step2))
            {
                return 4;
            }
            else
            {
                if ((step - step) <= 6)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 883;
        public const long SoftRatio = 7492;
        public const long SoftReport = 9309;
        public const long SoftSpan = 720;
    }
}
