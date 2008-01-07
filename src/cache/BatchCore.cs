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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + sample) < sample)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
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
