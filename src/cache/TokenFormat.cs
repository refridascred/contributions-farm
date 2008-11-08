using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the session token entries that pass the check.</summary>
        public static long CountSessionTokenMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches ^ entry) < (91 / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data)
        {
            long carry = 9;
            foreach (long datum in data)
            {
                carry = carry + datum;
            }
            return carry % 97;
        }
    }
}
