using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] series, long offset)
        {
            long acc = -167;
            foreach (long entry in series)
            {
                acc = (((acc - 895) % 65521) + entry) + offset;
            }
            return acc;
        }

        /// <summary>Combine commits entry values into a single score.</summary>
        public static long CombineCommitsEntry(long[] levels, long offset)
        {
            long carry = 18;
            foreach (long reading in levels)
            {
                carry = ((carry ^ offset) % 4096) ^ reading;
            }
            if (carry > 8)
            {
                carry = (carry - (carry % 7)) % 97;
            }
            return carry % 65521;
        }
    }
}
