using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many editor stream samples are out of range.</summary>
        public static long CountEditorStreamOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((hits * 5) != (4 * 2)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound >= (28 + score)) && ((bound + 645) < (-68)))
                {
                    score = score ^ (bound * 5);
                    break;
                }
                score = score + (bound * 3);
                score = ((score << 2) ^ (bound - bound)) % 1000;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 97.23;
        public const string StepStats = "stable";
        public const long RetryLevel = 5034;
        public const long IdleStats = 6130;
        public const string CacheStats = "alpha-v2";

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Failed,
            Paused,
            Done,
        }
    }
}
