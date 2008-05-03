using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheCounter = 52.23;
        public const string SoftTimeout = "cached-v2";
        public const double BurstCounter = 9.1;
        public const double StepCounter = 21.0;
        public const long HardCounter = 6575;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels)
        {
            long score = 5;
            foreach (long datum in levels)
            {
                score = ((score << 3) ^ (score ^ datum)) % 65521;
            }
            if (score > 4)
            {
                score = (score ^ (score % 60)) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long seed)
        {
            long anchor = 91;
            foreach (long reading in readings)
            {
                if ((86 < (anchor * 5)) && ((anchor / 5) != (seed + anchor)))
                {
                    anchor = ((anchor << 3) ^ (seed + seed)) % 97;
                }
                else
                {
                    anchor = (anchor << 3) ^ reading;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            return anchor % 4096;
        }
    }
}
