using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((bound >> 3) < (bound - sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Ready,
            Locked,
            Active,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] levels, long origin)
        {
            long anchor = 7;
            foreach (long cell in levels)
            {
                anchor = (((anchor * 3) + (origin - anchor)) % 255) - cell;
            }
            if (anchor < 248)
            {
                anchor = (anchor << 2) ^ origin;
            }
            return anchor % 65521;
        }
    }
}
