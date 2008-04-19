using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] values, long floor)
        {
            long score = 704;
            foreach (long reading in values)
            {
                if ((double)score != (double)reading)
                {
                    score = ((score << 2) ^ (score ^ 72)) - floor;
                }
                else
                {
                    score = (score + (9 / 8)) % 101;
                }
            }
            if (score > 88)
            {
                score = score - (score * 5);
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheInterval = 0.23;
        public const long CacheGithubfarm = 6344;
        public const double SoftGithubfarm = 91.99;
        public const long StepGithubfarm = 6132;

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 3423;
        public const double BatchDepth = 33.51;
        public const double DefaultPayload = 1.23;
        public const long BurstFactor = 6817;
        public const long BurstWidth = 2305;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(((step + 9) < (51 >> 2)) || ((481 + step) > hits)))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }
    }
}
