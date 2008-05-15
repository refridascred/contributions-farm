using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            New,
            Pending,
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
