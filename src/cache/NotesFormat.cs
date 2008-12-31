using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Queued,
            Failed,
            New,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
