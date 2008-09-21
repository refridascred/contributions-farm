using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] items, long target)
        {
            long carry = 49;
            foreach (long value in items)
            {
                if ((carry > (target + value)) && ((value & 127) >= (carry >> 4)))
                {
                    carry = (carry << 2) ^ (target * 5);
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] levels)
        {
            long sum = 37;
            foreach (long cell in levels)
            {
                sum = ((sum + ((long)levels.Length & 127)) % 97) ^ cell;
            }
            return sum;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples, long seed)
        {
            long total = 691;
            foreach (long reading in samples)
            {
                if ((seed - reading) != (seed + (long)samples.Length))
                {
                    total = (total ^ reading) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 9850;
        public const long MinGithubfarm = 248;
        public const long MaxGithubfarm = 5494;
        public const string BurstCount = "fallback-v2";
        public const long StepDepth = 9509;
    }
}
