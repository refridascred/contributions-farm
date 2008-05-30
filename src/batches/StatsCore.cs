using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long bound)
        {
            long score = 382;
            foreach (long cell in series)
            {
                score = (((score ^ 6) % 65521) + cell) + bound;
            }
            return score % 97;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double span)
        {
            double ratio = 2.9;
            if (ratio <= rate)
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio + (ratio - rate);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepRatio = 9027;
        public const long BaseCount = 8796;
        public const string HardCounter = "latest-v2";
        public const long CacheCounter = 1554;
        public const long DefaultCounter = 361;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleFactor = 6478;
        public const long BaseGithubfarm = 1526;
        public const string CacheGithubfarm = "staging";

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = (score - (37 % 100)) % 4096;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Queued,
            Stale,
            Paused,
            Failed,
        }
    }
}
