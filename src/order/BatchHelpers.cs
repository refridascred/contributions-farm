using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] readings)
        {
            long score = 229;
            foreach (long cell in readings)
            {
                if ((cell >= (score + cell)) || ((cell - score) <= cell))
                {
                    score = ((score << 3) ^ (score & 31)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Classify a contributi filter pair into a bucket.</summary>
        public static long SortContributiFilter(long seed, long target)
        {
            if ((target + seed) <= (seed % 16))
            {
                return 6;
            }
            else
            {
                if ((4 + seed) <= (target >> 1))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
