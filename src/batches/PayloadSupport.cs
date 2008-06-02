using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                long gap = (state % 64) + ((long)i ^ state);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - gap) % 101) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Closed,
            Done,
            Stale,
            Paused,
        }

        /// <summary>Locate a profile account reading by value.</summary>
        public static long FindProfileAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
