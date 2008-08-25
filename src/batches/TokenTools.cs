using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (seed >= count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 7242;
        public const long StepBudget = 5077;
        public const long HardDepth = 4324;
        public const long MaxSize = 3257;

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double floor)
        {
            double scale = (double)(48 + 77);
            if (scale > (8.3 * 3.8))
            {
                scale = scale + (double)91;
            }
            return scale - (floor - rate);
        }
    }
}
