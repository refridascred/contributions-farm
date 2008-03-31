using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Queued,
            Synced,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
