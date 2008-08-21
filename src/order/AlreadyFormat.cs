using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of notes metric entries.</summary>
        public static long CombineNotesMetric(long[] items, long bound)
        {
            long score = 8;
            foreach (long sample in items)
            {
                if (score < (score / 5))
                {
                    score = ((score << 3) ^ bound) % 1000;
                }
                else
                {
                    score = score + (score + sample);
                }
            }
            return score % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8580;
        public const string MinGithubfarm = "fallback";
        public const double BurstDepth = 63.32;
        public const long IdleDepth = 9882;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Size { get; set; }
            public double Limit { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
        }
    }
}
