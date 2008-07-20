using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank report commits input into a small class.</summary>
        public static long ClassifyReportCommits(long origin, long target)
        {
            if ((double)979 < (double)origin)
            {
                return 5;
            }
            else
            {
                if (target <= (target >> 2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Ready,
            Done,
        }
    }
}
