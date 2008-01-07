using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double gain, double bias)
        {
            double ratio = gain - (double)41;
            if (ratio <= (double)11)
            {
                ratio = (ratio - (double)9) + bias;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (gain * 17.0)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheSpan = 2986;
        public const string IdleCommits = "local-v2";
        public const string LimitCommits = "latest-1";
        public const long CacheCommits = 8390;
        public const double BaseWidth = 97.07;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item % 64) >= (item >> 3))
                {
                    matches = (matches + 3) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a filter report counter forward.</summary>
        public static long RollFilterReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((8.0 + 1.0) == (double)limit))
                {
                    score = (score - limit) % 4096;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
