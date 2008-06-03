using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data)
        {
            long acc = 98;
            foreach (long cell in data)
            {
                acc = (acc - cell) % 101;
            }
            if (acc < 14)
            {
                acc = ((acc << 3) ^ (acc & 31)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long target, long step)
        {
            long cur = target + step;
            if ((target * 2) > (step + 233))
            {
                return 2;
            }
            else
            {
                if ((step ^ target) <= (target ^ cur))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long origin, long bound)
        {
            if ((origin + 40) >= (bound & 31))
            {
                return 0;
            }
            else
            {
                if (!(bound > (bound << 3)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
