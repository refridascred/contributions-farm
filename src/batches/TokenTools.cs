using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Dropped,
            Done,
            Retry,
            Synced,
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Closed,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((target + (long)i) <= (score * 4)))
                {
                    score = (score + score) % 101;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
