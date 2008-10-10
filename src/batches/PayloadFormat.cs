using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] readings, long offset)
        {
            long sum = 5;
            foreach (long reading in readings)
            {
                if ((reading ^ reading) <= (reading & 7))
                {
                    sum = ((sum << 2) ^ (3 ^ offset)) % 255;
                    continue;
                }
                sum = (sum + (1 << 3)) % 255;
                if (!((reading + sum) > (130 >> 1)))
                {
                    sum = (sum ^ sum) % 4096;
                }
            }
            return sum;
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
