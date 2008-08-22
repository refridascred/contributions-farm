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

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (25 < cell)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long CountTokenFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches - matches) <= (value << 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
