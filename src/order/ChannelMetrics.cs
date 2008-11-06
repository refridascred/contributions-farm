using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] readings, long origin)
        {
            long state = 38;
            foreach (long value in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state ^ (205 & 255)) + (long)i) + origin;
                }
                state = (state << 3) ^ value;
            }
            return state;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 2) ^ (bound & 63)) % 4096;
                score = (score - 1) % 4096;
                score = score ^ score;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
