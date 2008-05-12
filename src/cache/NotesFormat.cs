using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFactor = "fallback-1";
        public const double WindowFilter = 16.76;
        public const double DefaultFactor = 32.41;
        public const long CacheWidth = 5883;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Ready,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
