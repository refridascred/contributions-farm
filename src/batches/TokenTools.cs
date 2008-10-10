using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] readings)
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

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double weight = offset;
            if (weight >= weight)
            {
                weight = weight + (rate * 9.9);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (rate / 8.0)) + (double)(long)i;
            }
            return weight + (weight - rate);
        }

        /// <summary>Roll a checks cache counter forward.</summary>
        public static long DeriveChecksCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (offset + offset)) % 97;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
