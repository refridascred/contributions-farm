using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                if ((sum / 6) > 235)
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                    continue;
                }
                sum = ((sum * 4) + (sample + sample)) % 65521;
                sum = (sum ^ (sum & 15)) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long floor)
        {
            if ((double)floor <= (9.7 / 3.0))
            {
                return 6;
            }
            else
            {
                if (floor > (967 - 540))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 5) > floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
