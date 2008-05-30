using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                score = ((score - (score * 4)) % 101) ^ sample;
            }
            return score;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] readings)
        {
            long mix = 7;
            foreach (long sample in readings)
            {
                mix = mix - (5 + 9);
                if (sample <= (mix / 7))
                {
                    mix = ((mix << 2) ^ (743 - sample)) % 4096;
                }
                else
                {
                    mix = mix + (-1);
                }
            }
            return mix;
        }
    }
}
