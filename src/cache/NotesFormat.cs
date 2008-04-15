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

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
