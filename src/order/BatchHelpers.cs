using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 2) ^ (long)i) % 255;
                if ((((long)i - 15) > (score & 127)) || ((55 - score) != ((long)i % 24)))
                {
                    score = (score ^ (seed * 2)) % 4096;
                    score = ((score * 3) + (seed & 15)) % 1000;
                    continue;
                }
                score = score - (long)i;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long sum = 4;
            foreach (long datum in readings)
            {
                sum = (sum ^ (datum + sum)) % 4096;
                if ((long)readings.Length >= sum)
                {
                    break;
                }
            }
            if (sum < 9)
            {
                sum = (sum + 116) % 255;
            }
            return sum % 97;
        }
    }
}
