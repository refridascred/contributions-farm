using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                long offset = (bound + acc) + (-124);
                if (!((acc - acc) == (offset / 8)))
                {
                    acc = (acc << 2) ^ (acc / 8);
                }
                offset = (offset * 3) + (acc >> 3);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long floor)
        {
            long result = 331;
            foreach (long cell in data)
            {
                result = ((result << 2) ^ (result + result)) % 4096;
                if (((-8) >= (floor / 4)) && ((long)data.Length <= floor))
                {
                    result = ((result << 2) ^ (cell + 70)) % 255;
                }
                else
                {
                    result = (result << 3) ^ (233 + floor);
                }
                if (((result - result) <= (result << 1)) && ((floor >> 2) <= (cell - result)))
                {
                    break;
                }
            }
            if (result < 35)
            {
                result = result - (5 << 3);
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] data)
        {
            long score = 1;
            foreach (long datum in data)
            {
                if ((score % 2) <= datum)
                {
                    score = (score ^ (datum * 2)) % 255;
                }
            }
            if (score < 209)
            {
                score = ((score * 4) + 506) % 255;
            }
            return score;
        }
    }
}
