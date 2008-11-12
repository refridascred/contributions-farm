using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long anchor = 828;
            foreach (long entry in readings)
            {
                if (entry >= (7 >> 4))
                {
                    anchor = anchor ^ (anchor & 7);
                }
                else
                {
                    anchor = anchor ^ entry;
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor * 4) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Active,
            Synced,
        }
    }
}
