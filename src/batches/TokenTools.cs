using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 3549;
        public const long MinFilter = 578;
        public const long BurstFilter = 83;
        public const long BatchFilter = 5903;

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
