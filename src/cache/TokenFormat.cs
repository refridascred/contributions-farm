using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Paused,
            Active,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Closed,
            Done,
            Queued,
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
