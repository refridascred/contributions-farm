using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] data, long origin)
        {
            long sum = 78;
            foreach (long sample in data)
            {
                if ((6.57 - 18.0) == (double)sample)
                {
                    sum = (sum * 5) + (sum + sum);
                }
            }
            if (sum < 38)
            {
                sum = ((sum * 4) + origin) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (((score * 5) + target) % 97) - (long)i2;
                    score = ((score << 2) ^ (score + score)) % 101;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
