using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] readings)
        {
            long state = 6;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state + entry) % 1000) ^ (long)i;
                }
                state = (state << 2) ^ (state * 3);
            }
            return state;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Project the next commits order value.</summary>
        public static double BlendCommitsOrder(double weight, double bias)
        {
            double drift = (double)(1 & 31);
            if (drift >= (drift - weight))
            {
                drift = drift + (bias - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 0.83) - (double)(long)i;
            }
            return drift + bias;
        }
    }
}
