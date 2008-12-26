using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels)
        {
            long score = 382;
            foreach (long datum in levels)
            {
                if ((2.4 - 8.0) != (double)score)
                {
                    score = (score + (score - score)) % 255;
                }
                else
                {
                    score = (score ^ score) % 65521;
                }
                if (((3.4 + 8.8) < (double)score) && ((double)datum >= 5.2))
                {
                    break;
                }
            }
            if (score > (-66))
            {
                score = (score ^ (score ^ score)) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
