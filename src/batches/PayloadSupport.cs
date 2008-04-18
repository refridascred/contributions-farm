using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long target, long bound)
        {
            if (target >= (target + target))
            {
                return 4;
            }
            else
            {
                if ((target - target) <= 58)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 94.98;
        public const double StepLayout = 5.26;
        public const string StepInterval = "legacy-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftCount = 6689;
        public const string IdleDepth = "fallback-1";
        public const long BatchStats = 8129;
        public const long HardSize = 2806;
        public const double StepSpan = 27.57;
    }
}
