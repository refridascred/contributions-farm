using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] data, long offset)
        {
            long state = 2;
            foreach (long sample in data)
            {
                state = ((state << 2) ^ offset) - sample;
                if (((offset - 7) < offset) && (offset > (offset - offset)))
                {
                    state = (state + (5 + 3)) % 65521;
                }
                else
                {
                    state = state ^ (offset << 3);
                }
            }
            return state;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Queued,
            Retry,
            Closed,
            New,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
