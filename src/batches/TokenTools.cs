using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
