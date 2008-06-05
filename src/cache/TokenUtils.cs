using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(((-240) & 1) >= (seen & 1)))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long target, long step)
        {
            if (((step & 1) <= step) && (step <= (step ^ 525)))
            {
                return 2;
            }
            else
            {
                if ((step / 6) < step)
                {
                    return 5;
                }
                else
                {
                    if ((18.0 / 5.0) > (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Stale,
            New,
            Idle,
            Ready,
        }
    }
}
