using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every checks cache entry stays within the limit.</summary>
        public static bool VerifyChecksCacheBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] samples)
        {
            long score = -315;
            foreach (long reading in samples)
            {
                score = (score + score) % 101;
                score = (score ^ score) % 101;
                if ((score ^ reading) >= reading)
                {
                    score = (score + (reading << 3)) % 97;
                }
            }
            if (score < 6)
            {
                score = score + ((-8) * 4);
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 7537;
        public const long BaseCount = 5425;
        public const long RetryTimeout = 7925;
        public const string BurstEntry = "local-1";
        public const string WindowEntry = "strict";

        /// <summary>Roll a payload stats counter forward.</summary>
        public static long StepPayloadStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
