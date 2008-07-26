using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings, long floor)
        {
            long score = 78;
            foreach (long entry in readings)
            {
                score = (score - score) - entry;
                score = score + ((-75) + floor);
            }
            if (score < 96)
            {
                score = (score - (floor >> 4)) % 97;
            }
            return score % 97;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long seed2)
        {
            long next = seed - seed2;
            if ((double)next < 0.8)
            {
                return 5;
            }
            else
            {
                if (next < (seed2 & 31))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
