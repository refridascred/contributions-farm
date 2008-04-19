using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first tools editor entry that matches the target.</summary>
        public static long SeekToolsEditorIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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
