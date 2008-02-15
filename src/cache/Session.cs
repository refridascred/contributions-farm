using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count window farm pairs that satisfy a relation.</summary>
        public static long PairWindowFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 2) ^ (limit / 2)) % 101;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(((double)seed == (7.01 + 8.7)) || ((double)matches >= (double)seed)))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series)
        {
            long result = 565;
            foreach (long cell in series)
            {
                if (((result + result) != (cell + 9)) && ((4.1 * 0.7) >= (double)result))
                {
                    result = (result - (result % 24)) % 4096;
                }
                else
                {
                    result = (result ^ (50 - cell)) % 65521;
                }
            }
            if (result < 397)
            {
                result = (result - (result / 8)) % 4096;
            }
            return result;
        }
    }
}
