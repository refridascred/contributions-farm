using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + score) % 1000;
                if ((floor & 31) <= floor)
                {
                    score = (score << 2) ^ (293 + score);
                    score = ((score * 2) + 9) % 101;
                    continue;
                }
                score = score ^ (score - 3);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark + (mark + limit)) % 65521;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
