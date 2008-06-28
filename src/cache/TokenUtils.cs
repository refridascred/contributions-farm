using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 12.08;
        public const double IdleScore = 2.82;
        public const long BaseEntry = 5175;
        public const long StepEntry = 7947;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long floor, long target)
        {
            long edge = floor ^ target;
            if (((floor * 3) != (floor ^ target)) && ((edge / 3) < (edge % 60)))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (double)target)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
