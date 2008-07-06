using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data, long target)
        {
            long state = 6;
            foreach (long datum in data)
            {
                if ((state / 5) < state)
                {
                    state = (state - datum) - target;
                }
                if (state >= (94 - state))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Count graph counter pairs that satisfy a relation.</summary>
        public static long CompareGraphCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Draft,
            Paused,
            Queued,
        }
    }
}
