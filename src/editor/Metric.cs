using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (seed - (long)i)) % 65521;
                if ((3 >> 2) < seed)
                {
                    score = score ^ (seed + seed);
                    score = ((score * 3) + (71 ^ (long)i)) % 97;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a tools order pair into a bucket.</summary>
        public static long SortToolsOrder(long offset, long target)
        {
            if ((target & 3) >= offset)
            {
                return 3;
            }
            else
            {
                if ((4.6 - 8.12) <= (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((offset - target) > (161 - target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
