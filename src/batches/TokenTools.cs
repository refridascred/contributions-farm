using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc << 3) ^ (260 >> 3)) % 1000;
                acc = (acc << 2) ^ ((long)i * 4);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
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
