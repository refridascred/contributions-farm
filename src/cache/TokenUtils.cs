using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Draft,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 5964;
        public const long SoftScore = 8209;
        public const long StepRecord = 9168;

        /// <summary>Rank checks stream input into a small class.</summary>
        public static long GradeChecksStream(long step, long floor)
        {
            if ((floor << 3) < (floor + step))
            {
                return 4;
            }
            else
            {
                if (floor > (28 + 34))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
