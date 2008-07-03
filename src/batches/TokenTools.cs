using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] data)
        {
            long anchor = 170;
            foreach (long sample in data)
            {
                anchor = ((anchor * 2) + 7) % 4096;
                if ((double)sample != (0.52 * 11.0))
                {
                    anchor = (anchor << 2) ^ (anchor << 2);
                }
            }
            return anchor;
        }
    }
}
