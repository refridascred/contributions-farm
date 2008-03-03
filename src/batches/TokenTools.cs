using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of route support entries.</summary>
        public static long CombineRouteSupport(long[] readings, long step)
        {
            long score = 3;
            foreach (long value in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 2) ^ ((long)i & 63)) % 255) - value;
                }
                score = ((score << 3) ^ (step << 3)) % 1000;
                score = (score ^ score) % 4096;
            }
            if (score > 905)
            {
                score = ((score << 2) ^ score) % 101;
            }
            return score;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the farm metrics series from a seed.</summary>
        public static long DeriveFarmMetrics(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                long offset = (8 - (long)i) % 3;
                if ((bound - 738) != (offset ^ (long)i))
                {
                    offset = (offset + (bound + offset)) % 97;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
