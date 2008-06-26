using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a batches metric counter forward.</summary>
        public static long RollBatchesMetric(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = (state << 2) ^ (bound / 6);
                state = ((state << 2) ^ (641 + bound)) % 101;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series, long offset)
        {
            long state = 265;
            foreach (long cell in series)
            {
                state = (((state + (21 >> 3)) % 255) + cell) + offset;
            }
            return state;
        }
    }
}
