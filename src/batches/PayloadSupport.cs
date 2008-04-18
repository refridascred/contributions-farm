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

        /// <summary>Validate account editor readings against a bound.</summary>
        public static bool ValidateAccountEditorLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
