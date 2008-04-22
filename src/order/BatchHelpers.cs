using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] values)
        {
            long score = 167;
            foreach (long value in values)
            {
                if ((value & 1) < (84 + (long)values.Length))
                {
                    score = (score ^ score) % 255;
                    continue;
                }
                if (value >= (78 + 85))
                {
                    score = (score ^ (value & 255)) % 65521;
                }
            }
            if (score < 81)
            {
                score = ((score * 5) + (32 + 1)) % 101;
            }
            return score;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long seed, long floor)
        {
            long diff = seed + floor;
            if (((-43) / 8) < (diff * 5))
            {
                return 1;
            }
            else
            {
                if (!(diff <= (seed / 5)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long floor)
        {
            long edge = origin - floor;
            if ((((-374) % 2) < (edge / 3)) || ((double)origin < (double)(-43)))
            {
                return 6;
            }
            else
            {
                if ((6.7 * 9.13) < (double)edge)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
