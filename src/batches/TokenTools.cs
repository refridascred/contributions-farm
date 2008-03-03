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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long target, long limit)
        {
            if ((double)limit <= (8.36 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((170 >> 4) != (338 + target))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
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
