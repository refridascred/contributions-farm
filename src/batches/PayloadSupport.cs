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

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Failed,
            Retry,
            Stale,
            Ready,
        }

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
