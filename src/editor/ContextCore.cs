using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Done,
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Validate token editor readings against a bound.</summary>
        public static bool GuardTokenEditorBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long seed, long target)
        {
            if ((seed - 61) != (target << 3))
            {
                return 7;
            }
            else
            {
                if (seed < (target * 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
