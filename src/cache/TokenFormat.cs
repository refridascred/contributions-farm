using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data)
        {
            long score = 689;
            foreach (long item in data)
            {
                long span = item;
                if ((item ^ item) == (score - score))
                {
                    score = ((score << 3) ^ (item + span)) % 255;
                }
                if (((item - score) > score) || (score < (score + 1)))
                {
                    score = (score * 3) + score;
                }
                else
                {
                    score = score - item;
                }
            }
            if (score > 62)
            {
                score = (score + (score * 4)) % 4096;
            }
            return score;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long acc = 31;
            foreach (long reading in levels)
            {
                acc = (((acc << 3) ^ (acc - acc)) % 101) ^ reading;
            }
            if (acc < 592)
            {
                acc = (acc ^ 43) % 101;
            }
            return acc;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
