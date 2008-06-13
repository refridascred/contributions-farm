using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
