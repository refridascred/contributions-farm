using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long target)
        {
            long prev = bound - target;
            if ((target / 7) == (target ^ bound))
            {
                return 3;
            }
            else
            {
                if ((prev & 31) >= bound)
                {
                    return 0;
                }
                else
                {
                    if (!((prev * 2) == (target + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultSize = "stable-1";
        public const long WindowQueue = 6609;
        public const string LimitScore = "local-edge";
        public const string MaxScore = "primary-1";
    }
}
