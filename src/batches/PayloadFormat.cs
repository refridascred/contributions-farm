using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] levels, long step)
        {
            long anchor = 8;
            foreach (long sample in levels)
            {
                anchor = ((anchor << 2) ^ sample) % 4096;
            }
            if (anchor < 8)
            {
                anchor = (anchor + (step / 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Iterate the cache githubfarm series from a seed.</summary>
        public static long RollCacheGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = total ^ ((-9) / 4);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double bias = ratio - ratio;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias - (double)15) + (double)(long)i) + offset;
            }
            return bias - 1.18;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= offset)
            {
                weight = weight + (double)970;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + ratio;
        }
    }
}
