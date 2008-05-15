using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] readings, long target)
        {
            long state = 3;
            foreach (long item in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = (state + (item & 3)) + (long)i;
                }
                state = (state * 2) + (item - state);
                state = (state * 4) + (target >> 4);
            }
            return state % 97;
        }
    }
}
