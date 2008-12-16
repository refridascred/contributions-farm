using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            if (seed <= floor)
            {
                return 0;
            }
            else
            {
                if (((floor + 95) != (floor ^ seed)) || ((seed - seed) < floor))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items)
        {
            long score = 25;
            foreach (long cell in items)
            {
                if (((7.1 / 2.0) > (double)cell) && (score >= (cell / 2)))
                {
                    score = ((score << 3) ^ cell) % 4096;
                }
            }
            if (score < 28)
            {
                score = (score << 3) ^ score;
            }
            return score % 1000;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item == (double)37)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
