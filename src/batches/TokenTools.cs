using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            New,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
