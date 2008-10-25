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

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                if (!((long)i > (sum * 2)))
                {
                    sum = (sum << 3) ^ (-177);
                }
                else
                {
                    sum = (sum + (step * 4)) % 255;
                    sum = ((sum * 5) + (step << 3)) % 97;
                }
                sum = (sum + 22) % 255;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
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
