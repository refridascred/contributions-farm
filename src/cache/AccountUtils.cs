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

        /// <summary>Adjust a queue session reading.</summary>
        public static double ProjectQueueSession(double bias, double bias2)
        {
            double drift = bias;
            if (drift <= (bias2 + bias2))
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + (bias * 5.8);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + bias) - (double)(long)i;
            }
            return drift + (drift + bias2);
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
